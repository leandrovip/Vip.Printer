using System.Collections.Generic;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class QrCode : IQrCode
    {
        private static byte[] Size(QrCodeSize size)
        {
            return new[] {(size + 3).ToByte()};
        }

        private static IEnumerable<byte> StoreQr(string qrData, QrCodeSize size)
        {
            var length = qrData.Length + 3;
            var b = (byte) (length % 255);
            var b2 = (byte) (length / 255);

            return new byte[] {27, 106, 49}
                .AddBytes(new byte[] {27, 129})
                .AddBytes(new[] {b})
                .AddBytes(new[] {b2})
                .AddBytes(Size(size))
                .AddBytes(new[] {'M'.ToByte()});
        }

        public byte[] Print(string qrData)
        {
            return Print(qrData, QrCodeSize.Size0);
        }

        public byte[] Print(string qrData, QrCodeSize qrCodeSize)
        {
            var list = new List<byte>();
            list.AddRange(StoreQr(qrData, qrCodeSize));
            list.AddRange(Encoding.UTF8.GetBytes(qrData));
            return list.ToArray();
        }
    }
}