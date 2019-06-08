using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    public class PaperCut : IPaperCut
    {
        public byte[] Full()
        {
            return new byte[] {29, 'V'.ToByte(), 65,3};
        }

        public byte[] Partial()
        {
            return new byte[] {29, 'V'.ToByte(), 65,3};
        }
    }
}