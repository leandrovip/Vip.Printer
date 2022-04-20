namespace Vip.Printer.Interfaces.Engine
{
    public interface IEngine
    {
        bool Send(string printer, byte[] content);
    }
}