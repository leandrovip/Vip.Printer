using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Printer
{
    public interface IPrinter
    {
        void PrintDocument();
        void Append(string value);
        void Append(byte[] value);
        void NewLine();
        void NewLines(int lines);

        void Separator();
        void ItalicMode(string value);
        void BoldMode(string value);
        void UnderlineMode(string value);
        void ExpandedMode(PrinterModeState state);
        void CondensedMode(PrinterModeState state);
    }
}