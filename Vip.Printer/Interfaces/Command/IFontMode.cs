using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Command
{
    internal interface IFontMode
    {
        byte[] Italic(string value);
        byte[] Bold(string value);
        byte[] Underline(string value);
        byte[] Expanded(PrinterModeState state);
        byte[] Condensed(PrinterModeState state);
    }
}