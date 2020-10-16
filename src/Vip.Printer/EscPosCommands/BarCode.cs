using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class BarCode : IBarCode
    {
        public byte[] Code128(string code)
        {
            return new byte[] {29, 119, 2} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 102, 1}) // font hri character
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 107, 73}) // printCode
                .AddBytes(new[] {(byte) (code.Length + 2)})
                .AddBytes(new byte[] {123, 66})
                .AddBytes(code);
        }

        public byte[] Code39(string code)
        {
            return new byte[] {29, 119, 2} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 102, 0}) // font hri character
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 107, 4})
                .AddBytes(code)
                .AddBytes(new byte[] {0});
        }

        public byte[] Ean13(string code)
        {
            if (code.Trim().Length != 13)
                return new byte[0];

            return new byte[] {29, 119, 2} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 107, 67, 12})
                .AddBytes(code.Substring(0, 12));
        }
    }
}