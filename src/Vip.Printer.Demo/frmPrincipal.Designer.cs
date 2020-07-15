namespace Vip.Printer.Demo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImprimirTeste = new System.Windows.Forms.Button();
            this.btnGaveta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnQrCode = new System.Windows.Forms.Button();
            this.btnCodigoDeBarras = new System.Windows.Forms.Button();
            this.btnCodigoEan13 = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.lblCaminhoImpressora = new System.Windows.Forms.Label();
            this.txtImpressora = new System.Windows.Forms.TextBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnAutoTeste = new System.Windows.Forms.Button();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.lblLinkGit = new System.Windows.Forms.LinkLabel();
            this.btnImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimirTeste
            // 
            this.btnImprimirTeste.Location = new System.Drawing.Point(12, 86);
            this.btnImprimirTeste.Name = "btnImprimirTeste";
            this.btnImprimirTeste.Size = new System.Drawing.Size(133, 44);
            this.btnImprimirTeste.TabIndex = 0;
            this.btnImprimirTeste.Text = "Imprimir Teste";
            this.btnImprimirTeste.UseVisualStyleBackColor = true;
            this.btnImprimirTeste.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnGaveta
            // 
            this.btnGaveta.Location = new System.Drawing.Point(209, 136);
            this.btnGaveta.Name = "btnGaveta";
            this.btnGaveta.Size = new System.Drawing.Size(133, 44);
            this.btnGaveta.TabIndex = 0;
            this.btnGaveta.Text = "Abrir Gaveta";
            this.btnGaveta.UseVisualStyleBackColor = true;
            this.btnGaveta.Click += new System.EventHandler(this.btnGaveta_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(209, 308);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 44);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnQrCode
            // 
            this.btnQrCode.Location = new System.Drawing.Point(12, 136);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(133, 44);
            this.btnQrCode.TabIndex = 2;
            this.btnQrCode.Text = "Imprimir QrCode";
            this.btnQrCode.UseVisualStyleBackColor = true;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // btnCodigoDeBarras
            // 
            this.btnCodigoDeBarras.Location = new System.Drawing.Point(209, 186);
            this.btnCodigoDeBarras.Name = "btnCodigoDeBarras";
            this.btnCodigoDeBarras.Size = new System.Drawing.Size(133, 44);
            this.btnCodigoDeBarras.TabIndex = 2;
            this.btnCodigoDeBarras.Text = "Imprimir Código de Barras";
            this.btnCodigoDeBarras.UseVisualStyleBackColor = true;
            this.btnCodigoDeBarras.Click += new System.EventHandler(this.btnCodigoDeBarras_Click);
            // 
            // btnCodigoEan13
            // 
            this.btnCodigoEan13.Location = new System.Drawing.Point(12, 186);
            this.btnCodigoEan13.Name = "btnCodigoEan13";
            this.btnCodigoEan13.Size = new System.Drawing.Size(133, 44);
            this.btnCodigoEan13.TabIndex = 3;
            this.btnCodigoEan13.Text = "Imprimir Código de Barras EAN13";
            this.btnCodigoEan13.UseVisualStyleBackColor = true;
            this.btnCodigoEan13.Click += new System.EventHandler(this.btnCodigoEan13_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInicializar.Location = new System.Drawing.Point(209, 236);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(133, 44);
            this.btnInicializar.TabIndex = 4;
            this.btnInicializar.Text = "Inicializar Impressora (Reset)";
            this.btnInicializar.UseVisualStyleBackColor = false;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // lblCaminhoImpressora
            // 
            this.lblCaminhoImpressora.AutoSize = true;
            this.lblCaminhoImpressora.Location = new System.Drawing.Point(9, 18);
            this.lblCaminhoImpressora.Name = "lblCaminhoImpressora";
            this.lblCaminhoImpressora.Size = new System.Drawing.Size(207, 13);
            this.lblCaminhoImpressora.TabIndex = 5;
            this.lblCaminhoImpressora.Text = "Digite o caminho ou o nome da impressora";
            // 
            // txtImpressora
            // 
            this.txtImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpressora.Location = new System.Drawing.Point(12, 34);
            this.txtImpressora.Name = "txtImpressora";
            this.txtImpressora.Size = new System.Drawing.Size(219, 23);
            this.txtImpressora.TabIndex = 6;
            // 
            // cboModelo
            // 
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Items.AddRange(new object[] {
            "Epson",
            "Bematech",
            "Daruma"});
            this.cboModelo.Location = new System.Drawing.Point(237, 33);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(105, 24);
            this.cboModelo.TabIndex = 7;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(234, 18);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(93, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo Impressão";
            // 
            // btnAutoTeste
            // 
            this.btnAutoTeste.Location = new System.Drawing.Point(12, 236);
            this.btnAutoTeste.Name = "btnAutoTeste";
            this.btnAutoTeste.Size = new System.Drawing.Size(133, 44);
            this.btnAutoTeste.TabIndex = 0;
            this.btnAutoTeste.Text = "Imprimir Auto Teste";
            this.btnAutoTeste.UseVisualStyleBackColor = true;
            this.btnAutoTeste.Click += new System.EventHandler(this.btnAutoTeste_Click);
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Location = new System.Drawing.Point(9, 318);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(141, 13);
            this.lblDireitos.TabIndex = 8;
            this.lblDireitos.Text = "Develop by Leandro Ferreira";
            // 
            // lblLinkGit
            // 
            this.lblLinkGit.AutoSize = true;
            this.lblLinkGit.Location = new System.Drawing.Point(9, 339);
            this.lblLinkGit.Name = "lblLinkGit";
            this.lblLinkGit.Size = new System.Drawing.Size(113, 13);
            this.lblLinkGit.TabIndex = 9;
            this.lblLinkGit.TabStop = true;
            this.lblLinkGit.Text = "github.com/leandrovip";
            this.lblLinkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGit_LinkClicked);
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(209, 86);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(133, 44);
            this.btnImagem.TabIndex = 0;
            this.btnImagem.Text = "Imprimir Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(354, 362);
            this.Controls.Add(this.lblLinkGit);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.txtImpressora);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblCaminhoImpressora);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnCodigoEan13);
            this.Controls.Add(this.btnCodigoDeBarras);
            this.Controls.Add(this.btnQrCode);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnGaveta);
            this.Controls.Add(this.btnAutoTeste);
            this.Controls.Add(this.btnImprimirTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Vip.Printer - Demonstração";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirTeste;
		private System.Windows.Forms.Button btnGaveta;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnQrCode;
		private System.Windows.Forms.Button btnCodigoDeBarras;
		private System.Windows.Forms.Button btnCodigoEan13;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Label lblCaminhoImpressora;
        private System.Windows.Forms.TextBox txtImpressora;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnAutoTeste;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.LinkLabel lblLinkGit;
        private System.Windows.Forms.Button btnImagem;
    }
}