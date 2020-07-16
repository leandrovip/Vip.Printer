using System.Drawing;

namespace Vip.Printer.Interfaces.Command
{
    public interface IImage
    {
        byte[] Print(Image image, bool highDensity);
    }
}