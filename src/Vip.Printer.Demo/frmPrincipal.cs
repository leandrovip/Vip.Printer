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

		#endregion
	}
}