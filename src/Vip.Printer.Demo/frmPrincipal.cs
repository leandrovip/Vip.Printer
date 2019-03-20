using System;
using System.Windows.Forms;
using Vip.Printer.Enums;

namespace Vip.Printer.Demo
{
	public partial class frmPrincipal : Form
	{
		#region Construtores

		public frmPrincipal()
		{
			InitializeComponent();
		}

		#endregion

		#region Eventos

		private void btnTexto_Click(object sender, EventArgs e)
		{
			var printer = new Printer(@"\\leandro\usb", PrinterType.Bematech);

			printer.Append("TESTE DE IMPRESSÃO NORMAL - 50 COLUNAS");
			printer.Append("....+....1....+....2....+....3....+....4....+....5");
			printer.Separator();
			printer.Append("Texto Normal");
			printer.ItalicMode("Texto Itálico");
			printer.BoldMode("Texto Negrito");
			printer.UnderlineMode("Texto Sublinhado");
			printer.ExpandedMode(PrinterModeState.On);
			printer.Append("Texto Expandido");
			printer.Append("....+....1....+....2....+");
			printer.ExpandedMode(PrinterModeState.Off);
			printer.CondensedMode(PrinterModeState.On);
			printer.Append("Texto condensado");
			printer.CondensedMode(PrinterModeState.Off);
			printer.Separator();

			printer.DoubleWidth2();
			printer.Append("Largura da Fonte 2");
			printer.DoubleWidth3();
			printer.Append("Largura da Fonte 3");
			printer.NormalWidth();
			printer.Append("Largura normal");
			printer.Separator();

			printer.AlignRight();
			printer.Append("Texto alinhado à direita");
			printer.AlignCenter();
			printer.Append("Texto alinhado ao centro");
			printer.AlignLeft();
			printer.Append("Texto alinhado à esquerda");

			printer.CondensedMode("TEXTO CONDENSADO 1");
			printer.CondensedMode("TEXTO CONDENSADO 2");
			printer.Append("Outro Texto");

			printer.NewLine();
			printer.Append("Final de Teste :)");
			printer.Separator();
			printer.PartialPaperCut();

			printer.PrintDocument();
		}

		private void btnGaveta_Click(object sender, EventArgs e)
		{
			var printer = new Printer("USB", PrinterType.Bematech);
			printer.OpenDrawer();
			printer.PrintDocument();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnQrCode_Click(object sender, EventArgs e)
		{
			var stringqrcode =
				"35190361099008000141599000022490004885145710|20190315181929|2479.35||K+VRwUKRomWZZcJhaeuJMIWxRb5QKP6Sh6BLzHZdmNdhPOvxo5Xx4oIYqkfA5sB6z4KzBepBLgDrYkeOCzjwVGWhvLA5C72eQzk9emvV6EIk6iXa9XU/HesRJAqqiSqjvvOvhR9orD0tTUj3DjwoZpn8vrSSK1v1nHxJZBah7r5e3FG8P93X47QgHJZXGRR7BSNA8CQ4N/hgEMqXbOCn/4zj0E6y5Xg/JcI09xC6vX+5SmILY2e1zEBIirxKsWpZN/DkXt/su79esaQFBJSgfCerok4kLK/vE54CMjJ//U5bhLRm/ocHuEJbg1Rvf36kpwIXEnPV/zG/luJita36qQ==";

			var printer = new Printer("USB", PrinterType.Bematech);
			printer.AlignCenter();
			printer.BoldMode("Teste de QRCode");
			printer.Separator();
			printer.Append("QrCode 1");
			printer.QrCode(stringqrcode);
			printer.NewLine();
			printer.Append("QrCode 2");
			printer.QrCode(stringqrcode, QrCodeSize.Size1);
			printer.NewLine();
			printer.Append("QrCode 3");
			printer.QrCode(stringqrcode, QrCodeSize.Size2);
			printer.NewLine();
			printer.BoldMode("Fim de Teste");
			printer.AlignLeft();
			printer.PartialPaperCut();

			printer.PrintDocument();
		}

		private void btnCodigoDeBarras_Click(object sender, EventArgs e)
		{
			var printer = new Printer("USB", PrinterType.Bematech);

			printer.Append("Teste de Código de Barras");
			printer.Separator();
			printer.Append("Code 128");
			printer.Code128("3519036109900800014159");
			printer.NewLine();
			printer.Append("Code 3 9");
			printer.Code39("TESTE");
			printer.NewLine();
			printer.Append("Fim de Teste");
			printer.PartialPaperCut();

			printer.PrintDocument();
		}

		private void btnCodigoEan13_Click(object sender, EventArgs e)
		{
			var printer = new Printer("USB", PrinterType.Bematech);

			printer.Append("EAN 13");
			printer.Ean13("7898173500051");
			printer.NewLine();
			printer.Append("Fim de Teste");
			printer.PartialPaperCut();

			printer.PrintDocument();
		}

		#endregion
	}
}