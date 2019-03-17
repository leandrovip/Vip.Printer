using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Command
{
    internal interface IFontMode
    {
        byte[] Italic(string value);
        byte[] Italic(PrinterModeState state);
        byte[] Bold(string value);
        byte[] Bold(PrinterModeState state);
        byte[] Underline(string value);
        byte[] Underline(PrinterModeState state);
        byte[] Expanded(string value);
        byte[] Expanded(PrinterModeState state);
        byte[] Condensed(string value);
        byte[] Condensed(PrinterModeState state);
    }
}