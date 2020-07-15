using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class FontWidth : IFontWidth
    {
        public byte[] DoubleWidth2()
        {
            return new byte[] {27, 14, 0};
        }

        public byte[] DoubleWidth3()
        {
            return new byte[] {27, 14, 0};
        }

        public byte[] Normal()
        {
            return new byte[] {20};
        }
    }
}