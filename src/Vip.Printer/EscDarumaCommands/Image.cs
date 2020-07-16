using System.Collections.Generic;
using System.Drawing;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscDarumaCommands
{
    internal class Image : IImage
    {
        public byte[] Print(System.Drawing.Image image, bool highDensity)
        {
            var list = new List<byte>();
            var bmp = new Bitmap(image);

            string send = "" + (char)27 + (char)51 + (char)0;
            byte[] data = new byte[send.Length];
            for (var i = 0; i < send.Length; i++) data[i] = (byte)send[i];

            list.AddRange(data);
            data[0] = (byte)'\x00';
            data[1] = (byte)'\x00';
            data[2] = (byte)'\x00';
            
            byte[] escBmp = { 0x1B, 0x2A, 0x00, 0x00, 0x00 };
            escBmp[2] = (byte)'\x21';
            escBmp[3] = (byte)(bmp.Width % 256);
            escBmp[4] = (byte)(bmp.Width / 256);
            
            for (var i = 0; i < bmp.Height / 24 + 1; i++)
            {
                list.AddRange(escBmp);
                for (var j = 0; j < bmp.Width; j++)
                {
                    for (var k = 0; k < 24; k++)
                        if (i * 24 + k < bmp.Height)
                        {
                            var pixelColor = bmp.GetPixel(j, i * 24 + k);
                            if (!(pixelColor.R > 160 && pixelColor.G > 160 && pixelColor.B > 160)) 
                                data[k / 8] += (byte)(128 >> (k % 8));
                            if (highDensity) 
                                continue;
                            if (pixelColor.R == 0) 
                                data[k / 8] += (byte)(128 >> (k % 8));
                        }
                    list.AddRange(data);

                    data[0] = (byte)'\x00';
                    data[1] = (byte)'\x00';
                    data[2] = (byte)'\x00';
                }
            }
            list.AddRange(new byte[] { 27, '@'.ToByte() });
            return list.ToArray();
        }
    }
}