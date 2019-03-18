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

using System.Collections.Generic;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.EscBemaCommands;
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

		#region FontMode

		public void ItalicMode(string value)
		{
			Append(_command.FontMode.Italic(value));
		}

		public void ItalicMode(PrinterModeState state)
		{
			Append(_command.FontMode.Italic(state));
		}

		public void BoldMode(string value)
		{
			Append(_command.FontMode.Bold(value));
		}

		public void BoldMode(PrinterModeState state)
		{
			Append(_command.FontMode.Bold(state));
		}

		public void UnderlineMode(string value)
		{
			Append(_command.FontMode.Underline(value));
		}

		public void UnderlineMode(PrinterModeState state)
		{
			Append(_command.FontMode.Underline(state));
		}

		public void ExpandedMode(string value)
		{
			Append(_command.FontMode.Expanded(value));
		}

		public void ExpandedMode(PrinterModeState state)
		{
			Append(_command.FontMode.Expanded(state));
		}

		public void CondensedMode(string value)
		{
			Append(_command.FontMode.Condensed(PrinterModeState.Off));
		}

		public void CondensedMode(PrinterModeState state)
		{
			Append(_command.FontMode.Condensed(state));
		}

		#endregion

		#region FontWidth

		public void NormalWidth()
		{
			Append(_command.FontWidth.Normal());
		}

		public void DoubleWidth2()
		{
			Append(_command.FontWidth.DoubleWidth2());
		}

		public void DoubleWidth3()
		{
			Append(_command.FontWidth.DoubleWidth3());
		}

		#endregion

		#region Alignment

		public void AlignLeft()
		{
			Append(_command.Alignment.Left());
		}

		public void AlignRight()
		{
			Append(_command.Alignment.Right());
		}

		public void AlignCenter()
		{
			Append(_command.Alignment.Center());
		}

		#endregion

		#region PaperCut

		public void FullPaperCut()
		{
			Append(_command.PaperCut.Full());
		}

		public void PartialPaperCut()
		{
			Append(_command.PaperCut.Partial());
		}

		#endregion

		#region Drawer

		public void OpenDrawer()
		{
			Append(_command.Drawer.Open());
		}

		#endregion

		#endregion
	}
}