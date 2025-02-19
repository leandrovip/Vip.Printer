using System;
using System.Collections.Generic;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class QrCode : IQrCode
    {
        private static byte[] Size(QrCodeSize size)
        {
            return new byte[] {29, 40, 107, 3, 0, 49, 67}
                .AddBytes(new[] {(byte) (size + 3)});
        }

        private IEnumerable<byte> ModelQr()
        {
            return new byte[] {29, 40, 107, 4, 0, 49, 65, 50, 0};
        }

        private IEnumerable<byte> ErrorQr()
        {
            return new byte[] {29, 40, 107, 3, 0, 49, 69, 48};
        }

        private static IEnumerable<byte> StoreQr(string qrData)
        {
            var data = Encoding.UTF8.GetBytes(qrData);

            var newData = new byte[data.Length + 1];
            Buffer.BlockCopy(data, 0, newData, 0, data.Length);
            newData[newData.Length - 1] = 0x00;

            var totalLength = newData.Length + 3;
            var pL = (byte) (totalLength % 256);
            var pH = (byte) (totalLength / 256);

            // Monta o comando de armazenamento: cabeçalho + newData
            var storeCommand = new byte[8 + newData.Length];
            storeCommand[0] = 29;  // GS
            storeCommand[1] = 40;  // (
            storeCommand[2] = 107; // k
            storeCommand[3] = pL;
            storeCommand[4] = pH;
            storeCommand[5] = 49; // '1'
            storeCommand[6] = 80; // 'P'
            storeCommand[7] = 48; // '0'
            Buffer.BlockCopy(newData, 0, storeCommand, 8, newData.Length);

            return storeCommand;
        }

        private IEnumerable<byte> PrintQr()
        {
            return new byte[] {29, 40, 107, 3, 0, 49, 81, 48};
        }

        public byte[] Print(string qrData)
        {
            return Print(qrData, QrCodeSize.Size0);
        }

        public byte[] Print(string qrData, QrCodeSize qrCodeSize)
        {
            var list = new List<byte>();

            list.AddRange(ModelQr());
            list.AddRange(Size(qrCodeSize));
            list.AddRange(ErrorQr());
            list.AddRange(StoreQr(qrData));
            list.AddRange(PrintQr());
            return list.ToArray();
        }
    }
}