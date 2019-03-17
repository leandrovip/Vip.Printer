using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscPosBemaCommands
{
    internal class EscBema : IPrintCommand
    {
        public IFontMode FontMode { get; set; }
        public ICharSize CharSize { get; set; }
        public int ColsNomal => 50;
        public int ColsCondensed => 67;

        public byte[] Separator()
        {
            return new byte[]
                {
                    27,
                    15
                }
                .AddBytes(new string('-', ColsCondensed))
                .AddBytes(new byte[]
                {
                    27,
                    'P'.ToByte()
                }).AddBytes("\r\n");
        }

        public EscBema()
        {
            FontMode = new FontMode();
            CharSize = new CharSize();
        }
    }
}