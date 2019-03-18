using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class Drawer : IDrawer
	{
		public byte[] Open()
		{
			return new byte[] {27, 'v'.ToByte(), 140};
		}
	}
}