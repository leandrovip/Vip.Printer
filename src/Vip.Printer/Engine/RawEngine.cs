using System;
using System.Runtime.InteropServices;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer.Engine
{
    internal class RawEngine : IEngine
    {
        #region Struct

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)] public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)] public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)] public string pDataType;
        }

        #endregion

        #region Declaration Dll

        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi,
            ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter,
            IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi,
            ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level,
            [In] [MarshalAs(UnmanagedType.LPStruct)]
            DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        #endregion

        #region Private Methods

        private bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
        {
            int dwError = 0, dwWritten = 0;
            var hPrinter = new IntPtr(0);
            var di = new DOCINFOA();
            var bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "VIP RAW PrinterDocument";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }

                    EndDocPrinter(hPrinter);
                }

                ClosePrinter(hPrinter);
            }

            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
                dwError = Marshal.GetLastWin32Error();

            return bSuccess;
        }

        private bool SendBytesToPrinter(string szPrinterName, byte[] data)
        {
            var pUnmanagedBytes = Marshal.AllocCoTaskMem(data.Length); // Allocate unmanaged memory
            Marshal.Copy(data, 0, pUnmanagedBytes, data.Length);       // copy bytes into unmanaged memory
            var retval = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, data.Length);
            Marshal.FreeCoTaskMem(pUnmanagedBytes); // Free the allocated unmanaged memory

            return retval;
        }

        #endregion

        #region Methods

        public bool Send(string printer, byte[] content)
        {
            return SendBytesToPrinter(printer, content);
        }

        #endregion
    }
}