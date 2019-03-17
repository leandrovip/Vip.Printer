using System.Collections.Generic;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.EscPosBemaCommands;
using Vip.Printer.Helper;
using Vip.Printer.Interfaces.Command;
using Vip.Printer.Interfaces.Printer;

namespace Vip.Printer
{
    public class Printer : IPrinter
    {
        #region Properties

        private byte[] _buffer;
        private readonly string _printerName;
        private readonly IPrintCommand _command;

        #endregion

        #region Constructors

        public Printer(string printerName, PrinterType type)
        {
            _printerName = string.IsNullOrEmpty(printerName) ? "temp.prn" : printerName.Trim();

            switch (type)
            {
                case PrinterType.Epson:
                    //Command = new EscPosEpson();
                    break;
                case PrinterType.Bematech:
                    _command = new EscBema();
                    break;
            }
        }

        #endregion

        #region Methods

        public void PrintDocument()
        {
            if (_buffer == null)
                return;

            RawPrinterHelper.SendBytesToPrinter(_printerName, _buffer);
        }

        public void Append(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;

            var list = new List<byte>();
            if (_buffer != null) list.AddRange(_buffer);
            list.AddRange(Encoding.GetEncoding(850).GetBytes(value + "\n"));

            _buffer = list.ToArray();
        }

        public void Append(byte[] value)
        {
            if (value == null)
                return;

            var list = new List<byte>();
            if (_buffer != null) list.AddRange(_buffer);
            list.AddRange(value);
            _buffer = list.ToArray();
        }

        public void NewLine()
        {
            Append("\n");
        }

        public void NewLines(int lines)
        {
            for (var i = 1; i < lines; i++)
                NewLine();
        }

        #endregion

        #region Commands

        public void Separator()
        {
            Append(_command.Separator());
        }

        public void ItalicMode(string value)
        {
            Append(_command.FontMode.Italic(value));
        }

        public void BoldMode(string value)
        {
            Append(_command.FontMode.Bold(value));
        }

        public void UnderlineMode(string value)
        {
            Append(_command.FontMode.Underline(value));
        }

        public void ExpandedMode(PrinterModeState state)
        {
            Append(_command.FontMode.Expanded(state));
        }

        public void CondensedMode(PrinterModeState state)
        {
            Append(_command.FontMode.Condensed(state));
        }

        #endregion
    }
}