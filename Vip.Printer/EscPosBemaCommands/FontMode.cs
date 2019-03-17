using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosBemaCommands
{
    internal class FontMode : IFontMode
    {
        public byte[] Italic(string value)
        {
            var data = new byte[] {27, '4'.ToByte()}
                .AddBytes(value)
                .AddBytes(new byte[] {27, '5'.ToByte()})
                .AddLF();

            return data;
        }

        public byte[] Bold(string value)
        {
            var data = new byte[] {27, 'E'.ToByte()}
                .AddBytes(value)
                .AddBytes(new byte[] {27, 'F'.ToByte()})
                .AddLF();

            return data;
        }

        public byte[] Underline(string value)
        {
            var data = new byte[] {27, '-'.ToByte(), 1}
                .AddBytes(value)
                .AddBytes(new byte[] {27, '-'.ToByte(), 0})
                .AddLF();

            return data;
        }

        public byte[] Expanded(PrinterModeState state)
        {
            return new byte[]
            {
                27, 'W'.ToByte(),
                state == PrinterModeState.On ? '1'.ToByte() : '0'.ToByte()
            };
        }

        public byte[] Condensed(PrinterModeState state)
        {
            return state == PrinterModeState.On
                ? new byte[] {27, 15}
                : new byte[] {27, 'P'.ToByte()};
        }
    }
}