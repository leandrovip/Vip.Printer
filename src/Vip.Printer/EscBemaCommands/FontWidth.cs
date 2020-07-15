using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class FontWidth : IFontWidth
	{
		public byte[] Normal()
		{
			return new byte[]
			{
				27,
				'W'.ToByte(),
				0,
				27,
				'd'.ToByte(),
				0
			};
		}

		public byte[] DoubleWidth2()
		{
			return new byte[]
			{
				27,
				'W'.ToByte(),
				1,
				27,
				'd'.ToByte(),
				1
			};
		}

		public byte[] DoubleWidth3()
		{
			return new byte[]
			{
				29,
				'!'.ToByte(),
				32
			};
		}
	}
}