using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class InitializePrint : IInitializePrint
    {
        public byte[] Initialize()
        {
            return new byte[] {27, '@'.ToByte()};
        }
    }
}