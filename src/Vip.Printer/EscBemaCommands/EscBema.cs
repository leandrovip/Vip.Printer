using Vip.Printer.Enums;
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
        public IPaperCut PaperCut { get; set; }
        public IDrawer Drawer { get; set; }
        public IQrCode QrCode { get; set; }
        public IBarCode BarCode { get; set; }
        public IInitializePrint InitializePrint { get; set; }
        public int ColsNomal => 50;
        public int ColsCondensed => 67;
        public int ColsExpanded => 25;

        #endregion

        #region Constructor

        public EscBema()
        {
            FontMode = new FontMode();
            FontWidth = new FontWidth();
            Alignment = new Alignment();
            PaperCut = new PaperCut();
            Drawer = new Drawer();
            QrCode = new QrCode();
            BarCode = new BarCode();
            InitializePrint = new InitializePrint();
        }

        #endregion

        #region Methods

        public byte[] Separator()
        {
            return FontMode.Condensed(PrinterModeState.On)
                .AddBytes(new string('-', ColsCondensed))
                .AddBytes(FontMode.Condensed(PrinterModeState.Off))
                .AddCrLF();
        }

        public byte[] AutoTest()
        {
            return new byte[] {0x1D, 0xF9, 0x29, 0x30};
        }

        #endregion
    }
}