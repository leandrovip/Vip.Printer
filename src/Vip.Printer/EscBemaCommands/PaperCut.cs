using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class PaperCut : IPaperCut
	{
		public byte[] Full()
		{
			return new byte[] {27, 'w'.ToByte()};
		}

		public byte[] Partial()
		{
			return new byte[] {27, 'm'.ToByte()};
		}
	}
}