using System;
using System.Diagnostics;
using System.IO;
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
            cboProtocolo.SelectedItem = cboProtocolo.Items[0];
        }

        private void lblLinkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/leandrovip");
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.TestPrinter();
            printer.PartialPaperCut();
            printer.PrintDocument();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "images");

            var printer = ObterPrinter();
            printer.AlignCenter();
            printer.WriteLine("Impressão de imagem");
            printer.Separator();
            printer.AlignLeft();
            printer.NewLine();
            printer.WriteLine("Imagem alinhada a esquerda");
            printer.Image(Path.Combine(directory, "logo-vip.bmp"));
            printer.NewLine();
            printer.AlignCenter();
            printer.WriteLine("Imagem alinhada ao centro");
            printer.Image(Path.Combine(directory, "logo-vip.bmp"));
            printer.NewLine();
            printer.AlignRight();
            printer.WriteLine("Imagem alinhada a direita");
            printer.Image(Path.Combine(directory, "logo-vip2.bmp"));
            printer.NewLine();
            printer.AlignLeft();
            printer.WriteLine("Fim de teste");
            printer.NewLines(3);
            printer.PartialPaperCut();
            printer.PrintDocument();
        }

        private void btnGaveta_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.OpenDrawer();
            printer.PrintDocument();
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            const string stringQrCode =
                "35190361099008000141599000022490004885145710|20190315181929|2479.35||K+VRwUKRomWZZcJhaeuJMIWxRb5QKP6Sh6BLzHZdmNdhPOvxo5Xx4oIYqkfA5sB6z4KzBepBLgDrYkeOCzjwVGWhvLA5C72eQzk9emvV6EIk6iXa9XU/HesRJAqqiSqjvvOvhR9orD0tTUj3DjwoZpn8vrSSK1v1nHxJZBah7r5e3FG8P93X47QgHJZXGRR7BSNA8CQ4N/hgEMqXbOCn/4zj0E6y5Xg/JcI09xC6vX+5SmILY2e1zEBIirxKsWpZN/DkXt/su79esaQFBJSgfCerok4kLK/vE54CMjJ//U5bhLRm/ocHuEJbg1Rvf36kpwIXEnPV/zG/luJita36qQ==";

            var printer = ObterPrinter();
            printer.AlignCenter();
            printer.BoldMode("Teste de QRCode");
            printer.Separator();
            printer.WriteLine("QrCode 1");
            printer.QrCode(stringQrCode);
            printer.NewLine();
            printer.WriteLine("QrCode 2");
            printer.QrCode(stringQrCode, QrCodeSize.Size1);
            printer.NewLine();
            printer.WriteLine("QrCode 3");
            printer.QrCode(stringQrCode, QrCodeSize.Size2);
            printer.NewLine();
            printer.BoldMode("Fim de Teste");
            printer.AlignLeft();
            printer.NewLines(5);
            printer.PartialPaperCut();

            printer.PrintDocument();
        }

        private void btnCodigoDeBarras_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.WriteLine("Teste de Código de Barras");
            printer.Separator();
            printer.WriteLine("Code 128");
            printer.Code128("3519036109900800014159");
            printer.WriteLine("Code  39");
            printer.Code39("TESTE");
            printer.WriteLine("Fim de Teste");
            printer.NewLines(5);
            printer.PartialPaperCut();

            printer.PrintDocument();
        }

        private void btnCodigoEan13_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.WriteLine("EAN 13");
            printer.Ean13("7898173500051");
            printer.NewLine();
            printer.WriteLine("Fim de Teste");
            printer.NewLines(5);
            printer.PartialPaperCut();

            printer.PrintDocument();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.InitializePrint();
            MessageBox.Show("Comando inicialize executado com sucesso!", "Vip.Printer");
        }

        private void btnAutoTeste_Click(object sender, EventArgs e)
        {
            var printer = ObterPrinter();
            printer.AutoTest();
            printer.PrintDocument();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Métodos

        private Printer ObterPrinter()
        {
            int.TryParse(txtNormal.Text, out var normal);
            int.TryParse(txtCondensado.Text, out var condensado);
            int.TryParse(txtExpandido.Text, out var expandido);
            return new Printer(txtImpressora.Text, ObterTipo(), normal, condensado, expandido, null, ObterProtocolo());
        }

        private PrinterType ObterTipo() => cboModelo.Text == "Bematech" ? PrinterType.Bematech : cboModelo.Text == "Daruma" ? PrinterType.Daruma : PrinterType.Epson;

        private ProtocolType ObterProtocolo()
        {
            switch (cboProtocolo.Text)
            {
                case "Raw":     return ProtocolType.Raw;
                case "Network": return ProtocolType.Network;
                default:        return ProtocolType.Raw;
            }
        }

        #endregion
    }
}