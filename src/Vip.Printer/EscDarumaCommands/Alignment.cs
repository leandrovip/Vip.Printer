using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    public class Alignment : IAlignment
    {
        public byte[] Center()
        {
            return new byte[] {27, 'j'.ToByte(), 1};
        }

        public byte[] Left()
        {
            return new byte[] {27, 'j'.ToByte(), 0};
        }

        public byte[] Right()
        {
            return new byte[] {27, 'j'.ToByte(), 2};
        }
    }
}