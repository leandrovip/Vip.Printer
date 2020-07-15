using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class FontWidth : IFontWidth
    {
        public byte[] Normal()
        {
            return new byte[] {27, '!'.ToByte(), 0};
        }

        public byte[] DoubleWidth2()
        {
            return new byte[] {29, '!'.ToByte(), 16};
        }

        public byte[] DoubleWidth3()
        {
            return new byte[] {29, '!'.ToByte(), 32};
        }
    }
}