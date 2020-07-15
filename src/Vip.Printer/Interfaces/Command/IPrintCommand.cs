﻿namespace Vip.Printer.Interfaces.Command
{
    internal interface IPrintCommand
    {
        int ColsNomal { get; }
        int ColsCondensed { get; }
        int ColsExpanded { get; }
        IFontMode FontMode { get; set; }
        IFontWidth FontWidth { get; set; }
        IAlignment Alignment { get; set; }
        IPaperCut PaperCut { get; set; }
        IDrawer Drawer { get; set; }
        IQrCode QrCode { get; set; }
        IImage Image { get; set; }
        IBarCode BarCode { get; set; }
        IInitializePrint InitializePrint { get; set; }
        byte[] Separator();
        byte[] AutoTest();
    }
}