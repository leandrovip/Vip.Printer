using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
    internal class BarCode : IBarCode
    {
        public byte[] Code128(string code)
        {
            return new byte[] {29, 119, 2} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 107, 73, 24, 123})
                .AddBytes(code);
        }

        public byte[] Code39(string code)
        {
            return new byte[] {29, 119, 13} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 102, 2})
                .AddBytes(new byte[] {29, 107, 69})
                .AddBytes(code);
        }

        public byte[] Ean13(string code)
        {
            if (code.Trim().Length != 13)
                return new byte[0];

            return new byte[] {29, 119, 40} // Width
                .AddBytes(new byte[] {29, 104, 50}) // Height
                .AddBytes(new byte[] {29, 72, 0}) // If print code informed
                .AddBytes(new byte[] {29, 107, 67, 12})
                .AddBytes(code.Substring(0, 12));
        }
    }
}