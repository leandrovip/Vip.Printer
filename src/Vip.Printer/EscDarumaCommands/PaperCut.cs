using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    public class PaperCut : IPaperCut
    {
        public byte[] Full()
        {
            return new byte[] { 27, 'm'.ToByte() };
        }

        public byte[] Partial()
        {
            return new byte[] { 27, 'm'.ToByte() };
        }
    }
}
