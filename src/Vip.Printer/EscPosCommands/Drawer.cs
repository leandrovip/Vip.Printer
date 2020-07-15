using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosCommands
{
    internal class Drawer : IDrawer
    {
        public byte[] Open()
        {
            return new byte[] {27, 112, 0, 60, 120};
        }
    }
}