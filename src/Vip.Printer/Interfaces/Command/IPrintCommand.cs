namespace Vip.Printer.Interfaces.Command
{
    internal interface IPrintCommand
    {
        int ColsNomal { get; }
        int ColsCondensed { get; }
        IFontMode FontMode { get; set; }
        ICharSize CharSize { get; set; }
        byte[] Separator();
    }
}