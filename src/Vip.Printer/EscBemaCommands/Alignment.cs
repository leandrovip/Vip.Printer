using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class Alignment : IAlignment
	{
		private static byte[] Align(Justifications justification)
		{
			byte align;
			switch (justification)
			{
				case Justifications.Right:
					align = '2'.ToByte();
					break;
				case Justifications.Center:
					align = '1'.ToByte();
					break;
				default:
					align = '0'.ToByte();
					break;
			}

			return new byte[]
			{
				27,
				'a'.ToByte(),
				align
			};
		}

		public byte[] Left()
		{
			return Align(Justifications.Left);
		}

		public byte[] Right()
		{
			return Align(Justifications.Right);
		}

		public byte[] Center()
		{
			return Align(Justifications.Center);
		}
	}
}