using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
    internal class Drawer : IDrawer
    {
        public byte[] Open()
        {
            return new byte[] {0x1B, 0x70, 0x00, 0x0A, 0x64};
        }
    }
}