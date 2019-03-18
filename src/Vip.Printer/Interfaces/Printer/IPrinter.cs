using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Printer
{
	internal interface IPrinter
	{
		void PrintDocument();
		void Append(string value);
		void Append(byte[] value);
		void NewLine();
		void NewLines(int lines);

		#region Commands

		void Separator();

		#region FontMode

		void ItalicMode(string value);
		void ItalicMode(PrinterModeState state);
		void BoldMode(string value);
		void BoldMode(PrinterModeState state);
		void UnderlineMode(string value);
		void UnderlineMode(PrinterModeState state);
		void ExpandedMode(string value);
		void ExpandedMode(PrinterModeState state);
		void CondensedMode(string value);
		void CondensedMode(PrinterModeState state);

		#endregion

		#region FontWidth

		void NormalWidth();
		void DoubleWidth2();
		void DoubleWidth3();

		#endregion

		#region Alignment

		void AlignLeft();
		void AlignRight();
		void AlignCenter();

		#endregion

		#region PaperCut

		void FullPaperCut();
		void PartialPaperCut();

		#endregion

		#region Drawer

		void OpenDrawer();

		#endregion

		#endregion
	}
}