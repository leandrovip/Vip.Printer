using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class EscBema : IPrintCommand
	{
		#region Properties

		public IFontMode FontMode { get; set; }
		public IFontWidth FontWidth { get; set; }
		public IAlignment Alignment { get; set; }
		public int ColsNomal => 50;
		public int ColsCondensed => 67;

		#endregion

		#region Constructor

		public EscBema()
		{
			FontMode = new FontMode();
			FontWidth = new FontWidth();
			Alignment = new Alignment();
		}

		#endregion

		#region Methods

		public byte[] Separator()
		{
			return new byte[] {27, 15}
				.AddBytes(new string('-', ColsCondensed))
				.AddBytes(new byte[] {27, 'P'.ToByte()})
				.AddBytes("\r\n");
		}

		#endregion
	}
}