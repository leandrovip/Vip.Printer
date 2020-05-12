using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    public class BarCode : IBarCode
    {
        public byte[] Code128(string code)
        {
            return new byte[] {27, 'b'.ToByte(), 5} // Code Type
                .AddBytes(new byte[] {2}) // Witdh
                .AddBytes(new byte[] {50}) // Height
                .AddBytes(new byte[] {0}) // If print code informed (1 print, 0 dont print)
                .AddBytes(code)
                .AddBytes(new byte[] {0});
        }

        public byte[] Code39(string code)
        {
            return new byte[] {27, 'b'.ToByte(), 6} // Code Type
                .AddBytes(new byte[] {2}) // Witdh
                .AddBytes(new byte[] {50}) // Height
                .AddBytes(new byte[] {0}) // If print code informed (1 print, 0 dont print)
                .AddBytes(code)
                .AddBytes(new byte[] {0});
        }

        public byte[] Ean13(string code)
        {
            if (code.Trim().Length != 13)
                return new byte[0];

            return new byte[] {27, 'b'.ToByte(), 1} // Code Type
                .AddBytes(new byte[] {2}) // Witdh
                .AddBytes(new byte[] {50}) // Height
                .AddBytes(new byte[] {0}) // If print code informed (1 print, 0 dont print)
                .AddBytes(code.Substring(0, 12))
                .AddBytes(new byte[] {0});
        }
    }
}