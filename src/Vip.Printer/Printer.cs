// ***********************************************************************
// Assembly         : Vip.Printer
// Author           : Leandro Ferreira
// Created          : 16-03-2019
//
// ***********************************************************************
// <copyright file="Printer.cs" company="VIP Soluções">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2019 VIP Soluções
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Vip.Printer.Engine;
using Vip.Printer.Enums;
using Vip.Printer.EscBemaCommands;
using Vip.Printer.EscDarumaCommands;
using Vip.Printer.EscPosCommands;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;
using Vip.Printer.Interfaces.Engine;
using Vip.Printer.Interfaces.Printer;
using Image = System.Drawing.Image;

namespace Vip.Printer
{
    public class Printer : IPrinter
    {
        #region Properties

        private byte[] _buffer;
        private readonly string _printerName;
        private readonly IEngine _engine;
        private readonly IPrintCommand _command;
        private readonly PrinterType _printerType;
        private Encoding _encoding;

        #endregion

        #region Public properties

        public int ColsNomal { get; private set; }
        public int ColsCondensed { get; private set; }
        public int ColsExpanded { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="printerName">Printer name, shared name or port of printer install</param>
        /// <param name="type">Command set of type printer</param>
        /// <param name="colsNormal">Number of columns for normal mode print</param>
        /// <param name="colsCondensed">Number of columns for condensed mode print</param>
        /// <param name="colsExpanded">Number of columns for expanded mode print</param>
        /// <param name="encoding">Custom encoding</param>
        /// <param name="protocol">Communication procotol</param>
        public Printer(string printerName, PrinterType type, int colsNormal, int colsCondensed, int colsExpanded, Encoding encoding, ProtocolType protocol)
        {
            _printerName = string.IsNullOrEmpty(printerName) ? "temp.prn" : printerName.Trim();
            _printerType = type;
            _encoding = encoding;
            _command = PrinterCommandFactory(type);
            _engine = EngineFactory(protocol);
            ConfigureCols(colsNormal, colsCondensed, colsExpanded);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="printerName">Printer name, shared name or port of printer install</param>
        /// <param name="type">Command set of type printer</param>
        /// <param name="colsNormal">Number of columns for normal mode print</param>
        /// <param name="colsCondensed">Number of columns for condensed mode print</param>
        /// <param name="colsExpanded">Number of columns for expanded mode print</param>
        public Printer(string printerName, PrinterType type, int colsNormal, int colsCondensed, int colsExpanded) : this(printerName, type, colsNormal, colsCondensed, colsExpanded, null, ProtocolType.Raw) { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="printerName">Printer name, shared name or port of printer install</param>
        /// <param name="type">Command set of type printer</param>
        /// <param name="encoding">Custom encoding</param>
        public Printer(string printerName, PrinterType type, Encoding encoding) : this(printerName, type, 0, 0, 0, encoding, ProtocolType.Raw) { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="printerName">Printer name, shared name or port of printer install</param>
        /// <param name="type">>Command set of type printer</param>
        /// <param name="protocol">>Communication protocol</param>
        public Printer(string printerName, PrinterType type, ProtocolType protocol) : this(printerName, type, 0, 0, 0, null, protocol) { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Printer" /> class.
        /// </summary>
        /// <param name="printerName">Printer name, shared name or port of printer install</param>
        /// <param name="type">>Command set of type printer</param>
        public Printer(string printerName, PrinterType type) : this(printerName, type, 0, 0, 0, null, ProtocolType.Raw) { }

        #endregion

        #region Methods

        public void PrintDocument(int copies = 1)
        {
            if (_buffer == null) return;
            if (copies <= 0) copies = 1;

            for (var i = 0; i < copies; i++)
                if (!_engine.Send(_printerName, _buffer))
                    throw new ArgumentException("Não foi possível acessar a impressora: " + _printerName);
        }

        public void Write(string value)
        {
            WriteString(value, false);
        }

        public void Write(byte[] value)
        {
            if (value == null)
                return;

            var list = new List<byte>();
            if (_buffer != null) list.AddRange(_buffer);
            list.AddRange(value);
            _buffer = list.ToArray();
        }

        public void WriteLine(string value)
        {
            WriteString(value, true);
        }

        private void WriteString(string value, bool useLf)
        {
            if (string.IsNullOrEmpty(value))
                return;

            if (useLf) value += "\n";

            var list = new List<byte>();
            if (_buffer != null) list.AddRange(_buffer);

            var bytes = _encoding != null
                ? _encoding.GetBytes(value)
                : _printerType == PrinterType.Bematech
                    ? Encoding.GetEncoding(850).GetBytes(value)
                    : Encoding.GetEncoding("IBM860").GetBytes(value);

            list.AddRange(bytes);
            _buffer = list.ToArray();
        }

        public void NewLine()
        {
            Write("\n");
        }

        public void NewLines(int lines)
        {
            for (var i = 1; i < lines; i++)
                NewLine();
        }

        public void Clear()
        {
            _buffer = null;
        }

        public void ConfigureCols(int normal, int condensed, int expanded)
        {
            ColsNomal = normal <= 0 ? _command.ColsNomal : normal;
            ColsCondensed = condensed <= 0 ? _command.ColsCondensed : condensed;
            ColsExpanded = expanded <= 0 ? _command.ColsExpanded : expanded;
        }

        public void ConfigureEncoding(Encoding encoding)
        {
            _encoding = encoding;
        }

        #region Obsolete Methods

        [Obsolete("This method changed to WriteLine")]
        public void Append(string value)
        {
            WriteLine(value);
        }

        [Obsolete("This method changed to Write")]
        public void AppendWithoutLf(string value)
        {
            Write(value);
        }

        [Obsolete("This method changed to Write")]
        public void Append(byte[] value)
        {
            Write(value);
        }

        #endregion

        #endregion

        #region Factory Methods

        private IPrintCommand PrinterCommandFactory(PrinterType type)
        {
            switch (type)
            {
                case PrinterType.Epson:
                    return new EscPos();
                case PrinterType.Bematech:
                    return new EscBema();
                case PrinterType.Daruma:
                    return new EscDaruma();
                default:
                    return new EscPos();
            }
        }

        private IEngine EngineFactory(ProtocolType protocol)
        {
            switch (protocol)
            {
                case ProtocolType.Raw:     return new RawEngine();
                case ProtocolType.Network: return new NetworkEngine();
                default: return new RawEngine();
            }
        }

        #endregion

        #region Commands

        #region Utils

        public void Separator()
        {
            var bytes = _command.FontMode.Condensed(PrinterModeState.On)
                .AddBytes(new string('-', ColsCondensed))
                .AddBytes(_command.FontMode.Condensed(PrinterModeState.Off))
                .AddLF();

            Write(bytes);
        }

        public void AutoTest()
        {
            Write(_command.AutoTest());
        }

        public void TestPrinter()
        {
            AlignLeft();
            WriteLine("TESTE DE IMPRESSÃO NORMAL - 48 COLUNAS");
            WriteLine("....+....1....+....2....+....3....+....4....+...");
            Separator();
            WriteLine("Texto Normal");
            ItalicMode("Texto Itálico");
            BoldMode("Texto Negrito");
            UnderlineMode("Texto Sublinhado");
            ExpandedMode(PrinterModeState.On);
            WriteLine("Texto Expandido");
            WriteLine("....+....1....+....2....");
            ExpandedMode(PrinterModeState.Off);
            CondensedMode(PrinterModeState.On);
            WriteLine("Texto condensado");
            CondensedMode(PrinterModeState.Off);

            NewLine();
            WriteLine($"COLUNAS NORMAL - {ColsNomal}");
            WriteLine(new string('-', ColsNomal));
            WriteLine($"COLUNAS CONDENSADO - {ColsCondensed}");
            CondensedMode(new string('-', ColsCondensed));
            WriteLine($"COLUNAS EXPANDIDO - {ColsExpanded}");
            ExpandedMode(new string('-', ColsExpanded));

            NewLine();
            DoubleWidth2();
            WriteLine("Largura Fonte 2");
            DoubleWidth3();
            WriteLine("Largura Fonte 3");
            NormalWidth();
            WriteLine("Largura normal");
            Separator();

            AlignRight();
            WriteLine("Texto alinhado à direita");
            AlignCenter();
            WriteLine("Texto alinhado ao centro");
            AlignLeft();
            WriteLine("Texto alinhado à esquerda");
            NewLines(3);
            WriteLine("Final de Teste :)");
            Separator();
            NewLine();
        }

        #endregion

        #region FontMode

        public void ItalicMode(string value)
        {
            Write(_command.FontMode.Italic(value));
        }

        public void ItalicMode(PrinterModeState state)
        {
            Write(_command.FontMode.Italic(state));
        }

        public void BoldMode(string value)
        {
            Write(_command.FontMode.Bold(value));
        }

        public void BoldMode(PrinterModeState state)
        {
            Write(_command.FontMode.Bold(state));
        }

        public void UnderlineMode(string value)
        {
            Write(_command.FontMode.Underline(value));
        }

        public void UnderlineMode(PrinterModeState state)
        {
            Write(_command.FontMode.Underline(state));
        }

        public void ExpandedMode(string value)
        {
            Write(_command.FontMode.Expanded(value));
        }

        public void ExpandedMode(PrinterModeState state)
        {
            Write(_command.FontMode.Expanded(state));
        }

        public void CondensedMode(string value)
        {
            Write(_command.FontMode.Condensed(value));
        }

        public void CondensedMode(PrinterModeState state)
        {
            Write(_command.FontMode.Condensed(state));
        }

        #endregion

        #region FontWidth

        public void NormalWidth()
        {
            Write(_command.FontWidth.Normal());
        }

        public void DoubleWidth2()
        {
            Write(_command.FontWidth.DoubleWidth2());
        }

        public void DoubleWidth3()
        {
            Write(_command.FontWidth.DoubleWidth3());
        }

        #endregion

        #region Alignment

        public void AlignLeft()
        {
            Write(_command.Alignment.Left());
        }

        public void AlignRight()
        {
            Write(_command.Alignment.Right());
        }

        public void AlignCenter()
        {
            Write(_command.Alignment.Center());
        }

        #endregion

        #region PaperCut

        public void FullPaperCut()
        {
            Write(_command.PaperCut.Full());
        }

        public void FullPaperCut(bool predicate)
        {
            if (predicate)
                FullPaperCut();
        }

        public void PartialPaperCut()
        {
            Write(_command.PaperCut.Partial());
        }

        public void PartialPaperCut(bool predicate)
        {
            if (predicate)
                PartialPaperCut();
        }

        #endregion

        #region Drawer

        public void OpenDrawer()
        {
            Write(_command.Drawer.Open());
        }

        #endregion

        #region QrCode

        public void QrCode(string qrData)
        {
            Write(_command.QrCode.Print(qrData));
        }

        public void QrCode(string qrData, QrCodeSize qrCodeSize)
        {
            Write(_command.QrCode.Print(qrData, qrCodeSize));
        }

        #endregion

        #region Image

        public void Image(string path, bool highDensity = true)
        {
            if (!File.Exists(path))
                throw new Exception("Image file not found");

            using (var image = System.Drawing.Image.FromFile(path)) Write(_command.Image.Print(image, highDensity));
        }

        public void Image(Stream stream, bool highDensity = true)
        {
            using (var image = System.Drawing.Image.FromStream(stream)) Write(_command.Image.Print(image, highDensity));
        }

        public void Image(byte[] bytes, bool highDensity = true)
        {
            using (var ms = new MemoryStream(bytes))
                Write(_command.Image.Print(System.Drawing.Image.FromStream(ms), highDensity));
        }

        public void Image(Image image, bool highDensity = true)
        {
            Write(_command.Image.Print(image, highDensity));
        }

        #endregion

        #region BarCode

        public void Code128(string code)
        {
            Write(_command.BarCode.Code128(code));
        }

        public void Code39(string code)
        {
            Write(_command.BarCode.Code39(code));
        }

        public void Ean13(string code)
        {
            Write(_command.BarCode.Ean13(code));
        }

        #endregion

        #region InitializePrint

        public void InitializePrint()
        {
            _engine.Send(_printerName, _command.InitializePrint.Initialize());
        }

        #endregion

        #endregion
    }
}