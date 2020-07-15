using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class FontMode : IFontMode
    {
        public byte[] Bold(string value)
        {
            return Bold(PrinterModeState.On)
                .AddBytes(value)
                .AddBytes(Bold(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] Bold(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, 'E'.ToByte()}
                : new byte[] {27, 'F'.ToByte()};
        }

        public byte[] Condensed(string value)
        {
            return Condensed(PrinterModeState.On)
                .AddBytes(value)
                .AddBytes(Condensed(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] Condensed(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, 15}
                : new byte[] {27, 18, 20};
        }

        public byte[] Expanded(string value)
        {
            return Expanded(PrinterModeState.On)
                .AddBytes(value)
                .AddBytes(Expanded(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] Expanded(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, 'w'.ToByte(), 1}
                : new byte[] {27, 'w'.ToByte(), 0};
        }

        public byte[] Italic(string value)
        {
            return Italic(PrinterModeState.On)
                .AddBytes(value)
                .AddBytes(Italic(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] Italic(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, '4'.ToByte(), 1}
                : new byte[] {27, '4'.ToByte(), 0};
        }

        public byte[] Underline(string value)
        {
            return Underline(PrinterModeState.On)
                .AddBytes(value)
                .AddBytes(Underline(PrinterModeState.Off))
                .AddLF();
        }

        public byte[] Underline(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, '-'.ToByte(), 1}
                : new byte[] {27, '-'.ToByte(), 0};
        }
    }
}