using System.Drawing;
using System.IO;
using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Printer
{
    internal interface IPrinter
    {
        int ColsNomal { get; }
        int ColsCondensed { get; }
        int ColsExpanded { get; }
        void PrintDocument();
        void Write(string value);
        void Write(byte[] value);
        void WriteLine(string value);
        void NewLine();
        void NewLines(int lines);
        void Clear();

        void Append(string value);
        void Append(byte[] value);
        void AppendWithoutLf(string value);

        #region Commands

        void Separator();
        void AutoTest();
        void TestPrinter();

        #region FontMode

        void ItalicMode(string value);
        void ItalicMode(PrinterModeState state);
        void BoldMode(string value);
        void BoldMode(PrinterModeState state);
        void UnderlineMode(string value);
        void UnderlineMode(PrinterModeState state);
        void ExpandedMode(string value);
        void ExpandedMode(PrinterModeState state);
        void CondensedMode(string value);
        void CondensedMode(PrinterModeState state);

        #endregion

        #region FontWidth

        void NormalWidth();
        void DoubleWidth2();
        void DoubleWidth3();

        #endregion

        #region Alignment

        void AlignLeft();
        void AlignRight();
        void AlignCenter();

        #endregion

        #region PaperCut

        void FullPaperCut();
        void FullPaperCut(bool predicate);
        void PartialPaperCut();
        void PartialPaperCut(bool predicate);

        #endregion

        #region Drawer

        void OpenDrawer();

        #endregion

        #region QrCode

        void QrCode(string qrData);
        void QrCode(string qrData, QrCodeSize qrCodeSize);

        #endregion

        #region Image

        void Image(string path, bool highDensity);
        void Image(Stream stream, bool highDensity);
        void Image(byte[] bytes, bool highDensity);
        void Image(Image image, bool highDensity);
        
        #endregion

        #region BarCode

        void Code128(string code);
        void Code39(string code);
        void Ean13(string code);

        #endregion

        #region InitializePrint

        void InitializePrint();

        #endregion

        #endregion
    }
}