using System;
using System.Diagnostics;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboModelo.SelectedItem = cboModelo.Items[0];
        }

        private void lblLinkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/leandrovip");
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            var printer = new Printer(txtImpressora.Text, ObterTipo());

            printer.TestPrinter();
            printer.PartialPaperCut();
            printer.PrintDocument();
        }

        private void btnGaveta_Click(object sender, EventArgs e)
        {
            var printer = new Printer(txtImpressora.Text, ObterTipo());
            printer.OpenDrawer();
            printer.PrintDocument();
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            var stringQrCode =
                "35190361099008000141599000022490004885145710|20190315181929|2479.35||K+VRwUKRomWZZcJhaeuJMIWxRb5QKP6Sh6BLzHZdmNdhPOvxo5Xx4oIYqkfA5sB6z4KzBepBLgDrYkeOCzjwVGWhvLA5C72eQzk9emvV6EIk6iXa9XU/HesRJAqqiSqjvvOvhR9orD0tTUj3DjwoZpn8vrSSK1v1nHxJZBah7r5e3FG8P93X47QgHJZXGRR7BSNA8CQ4N/hgEMqXbOCn/4zj0E6y5Xg/JcI09xC6vX+5SmILY2e1zEBIirxKsWpZN/DkXt/su79esaQFBJSgfCerok4kLK/vE54CMjJ//U5bhLRm/ocHuEJbg1Rvf36kpwIXEnPV/zG/luJita36qQ==";

            var printer = new Printer(txtImpressora.Text, ObterTipo());
            printer.AlignCenter();
            printer.BoldMode("Teste de QRCode");
            printer.Separator();
            printer.Append("QrCode 1");
            printer.QrCode(stringQrCode);
            printer.NewLine();
            printer.Append("QrCode 2");
            printer.QrCode(stringQrCode, QrCodeSize.Size1);
            printer.NewLine();
            printer.Append("QrCode 3");
            printer.QrCode(stringQrCode, QrCodeSize.Size2);
            printer.NewLine();
            printer.BoldMode("Fim de Teste");
            printer.AlignLeft();
            printer.PartialPaperCut();

            printer.PrintDocument();
        }

        private void btnCodigoDeBarras_Click(object sender, EventArgs e)
        {
            var printer = new Printer(txtImpressora.Text, ObterTipo());
            printer.Append("Teste de Código de Barras");
            printer.Separator();
            printer.Append("Code 128");
            printer.Code128("0123456789012345672365");
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
            var printer = new Printer(txtImpressora.Text, ObterTipo());

            printer.Append("EAN 13");
            printer.Ean13("7898173500051");
            printer.NewLine();
            printer.Append("Fim de Teste");
            printer.PartialPaperCut();

            printer.PrintDocument();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            var printer = new Printer(txtImpressora.Text, ObterTipo());
            printer.InitializePrint();

            MessageBox.Show("Comando inicialize executado com sucesso!", "Vip.Printer");
        }

        private void btnAutoTeste_Click(object sender, EventArgs e)
        {
            var printer = new Printer(txtImpressora.Text, ObterTipo());
            printer.AutoTest();
            printer.PrintDocument();

            MessageBox.Show("Comando inicialize executado com sucesso!", "Vip.Printer");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Métodos

        private PrinterType ObterTipo()
        {
            return cboModelo.Text == "Bematech" ? PrinterType.Bematech : PrinterType.Epson;
        }

        #endregion
    }
}