using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    public class Drawer : IDrawer
    {
        public byte[] Open()
        {
            return new byte[] {27, 'p'.ToByte()};
        }
    }
}