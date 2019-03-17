using System;
using System.Windows.Forms;
using Vip.Printer.Enums;

namespace Vip.Printer.Demo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

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

            //printer.NewLines(2);
            printer.Append("Final de Teste :)");
            printer.Separator();

            printer.PrintDocument();
        }
    }
}