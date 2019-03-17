using System.Collections.Generic;
using System.Text;

namespace Vip.Printer.Extensions
{
    internal static class PrinterExtensions
    {
        public static byte ToByte(this char c)
        {
            return (byte) c;
        }

        public static byte ToByte(this short c)
        {
            return (byte) c;
        }

        public static byte[] AddBytes(this byte[] bytes, byte[] addBytes)
        {
            if (addBytes == null)
                return bytes;

            var list = new List<byte>();
            list.AddRange(bytes);
            list.AddRange(addBytes);
            return list.ToArray();
        }

        public static byte[] AddBytes(this byte[] bytes, string value)
        {
            if (string.IsNullOrEmpty(value))
                return bytes;

            var list = new List<byte>();
            list.AddRange(bytes);
            list.AddRange(Encoding.GetEncoding(850).GetBytes(value));
            return list.ToArray();
        }

        public static byte[] AddLF(this byte[] bytes)
        {
            return bytes.AddBytes("\n");
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}