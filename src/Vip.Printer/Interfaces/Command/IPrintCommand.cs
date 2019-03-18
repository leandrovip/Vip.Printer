namespace Vip.Printer.Interfaces.Command
{
    internal interface IPrintCommand
    {
        int ColsNomal { get; }
        int ColsCondensed { get; }
        IFontMode FontMode { get; set; }
        IFontWidth FontWidth { get; set; }
        byte[] Separator();
    }
}