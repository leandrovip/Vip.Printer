namespace Vip.Printer.Demo.Net6
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
            btnImprimirTeste = new Button();
            btnGaveta = new Button();
            btnSair = new Button();
            btnQrCode = new Button();
            btnCodigoDeBarras = new Button();
            btnCodigoEan13 = new Button();
            btnInicializar = new Button();
            lblCaminhoImpressora = new Label();
            txtImpressora = new TextBox();
            cboModelo = new ComboBox();
            lblModelo = new Label();
            btnAutoTeste = new Button();
            lblDireitos = new Label();
            lblLinkGit = new LinkLabel();
            btnImagem = new Button();
            txtNormal = new TextBox();
            lblNormal = new Label();
            lblCondensado = new Label();
            txtCondensado = new TextBox();
            lblExpandido = new Label();
            txtExpandido = new TextBox();
            cboProtocolo = new ComboBox();
            label1 = new Label();
            gpbColunas = new GroupBox();
            gpbColunas.SuspendLayout();
            SuspendLayout();
            // 
            // btnImprimirTeste
            // 
            btnImprimirTeste.Font = new Font("Verdana", 8.25F);
            btnImprimirTeste.Location = new Point(12, 159);
            btnImprimirTeste.Name = "btnImprimirTeste";
            btnImprimirTeste.Size = new Size(209, 44);
            btnImprimirTeste.TabIndex = 4;
            btnImprimirTeste.Text = "Imprimir Teste";
            btnImprimirTeste.UseVisualStyleBackColor = true;
            btnImprimirTeste.Click += btnTexto_Click;
            // 
            // btnGaveta
            // 
            btnGaveta.Font = new Font("Verdana", 8.25F);
            btnGaveta.Location = new Point(245, 209);
            btnGaveta.Name = "btnGaveta";
            btnGaveta.Size = new Size(208, 44);
            btnGaveta.TabIndex = 7;
            btnGaveta.Text = "Abrir Gaveta";
            btnGaveta.UseVisualStyleBackColor = true;
            btnGaveta.Click += btnGaveta_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            btnSair.Location = new Point(245, 377);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(208, 44);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnQrCode
            // 
            btnQrCode.Font = new Font("Verdana", 8.25F);
            btnQrCode.Location = new Point(12, 209);
            btnQrCode.Name = "btnQrCode";
            btnQrCode.Size = new Size(209, 44);
            btnQrCode.TabIndex = 6;
            btnQrCode.Text = "Imprimir QrCode";
            btnQrCode.UseVisualStyleBackColor = true;
            btnQrCode.Click += btnQrCode_Click;
            // 
            // btnCodigoDeBarras
            // 
            btnCodigoDeBarras.Font = new Font("Verdana", 8.25F);
            btnCodigoDeBarras.Location = new Point(245, 259);
            btnCodigoDeBarras.Name = "btnCodigoDeBarras";
            btnCodigoDeBarras.Size = new Size(208, 44);
            btnCodigoDeBarras.TabIndex = 9;
            btnCodigoDeBarras.Text = "Imprimir Código de Barras";
            btnCodigoDeBarras.UseVisualStyleBackColor = true;
            btnCodigoDeBarras.Click += btnCodigoDeBarras_Click;
            // 
            // btnCodigoEan13
            // 
            btnCodigoEan13.Font = new Font("Verdana", 8.25F);
            btnCodigoEan13.Location = new Point(12, 259);
            btnCodigoEan13.Name = "btnCodigoEan13";
            btnCodigoEan13.Size = new Size(209, 44);
            btnCodigoEan13.TabIndex = 8;
            btnCodigoEan13.Text = "Imprimir Código de Barras EAN13";
            btnCodigoEan13.UseVisualStyleBackColor = true;
            btnCodigoEan13.Click += btnCodigoEan13_Click;
            // 
            // btnInicializar
            // 
            btnInicializar.Font = new Font("Verdana", 8.25F);
            btnInicializar.Location = new Point(245, 309);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(208, 44);
            btnInicializar.TabIndex = 11;
            btnInicializar.Text = "Inicializar Impressora (Reset)";
            btnInicializar.UseVisualStyleBackColor = false;
            btnInicializar.Click += btnInicializar_Click;
            // 
            // lblCaminhoImpressora
            // 
            lblCaminhoImpressora.AutoSize = true;
            lblCaminhoImpressora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaminhoImpressora.Location = new Point(9, 18);
            lblCaminhoImpressora.Name = "lblCaminhoImpressora";
            lblCaminhoImpressora.Size = new Size(218, 15);
            lblCaminhoImpressora.TabIndex = 13;
            lblCaminhoImpressora.Text = "Caminho, nome ou porta da impressora";
            // 
            // txtImpressora
            // 
            txtImpressora.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImpressora.Location = new Point(12, 34);
            txtImpressora.Name = "txtImpressora";
            txtImpressora.Size = new Size(233, 23);
            txtImpressora.TabIndex = 0;
            // 
            // cboModelo
            // 
            cboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModelo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboModelo.FormattingEnabled = true;
            cboModelo.Items.AddRange(new object[] { "Epson", "Bematech", "Daruma" });
            cboModelo.Location = new Point(251, 33);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(102, 24);
            cboModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(248, 18);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(105, 15);
            lblModelo.TabIndex = 14;
            lblModelo.Text = "Modelo Impressão";
            // 
            // btnAutoTeste
            // 
            btnAutoTeste.Font = new Font("Verdana", 8.25F);
            btnAutoTeste.Location = new Point(12, 309);
            btnAutoTeste.Name = "btnAutoTeste";
            btnAutoTeste.Size = new Size(209, 44);
            btnAutoTeste.TabIndex = 10;
            btnAutoTeste.Text = "Imprimir Auto Teste";
            btnAutoTeste.UseVisualStyleBackColor = true;
            btnAutoTeste.Click += btnAutoTeste_Click;
            // 
            // lblDireitos
            // 
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireitos.Location = new Point(9, 385);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(165, 15);
            lblDireitos.TabIndex = 16;
            lblDireitos.Text = "Develop by Leandro Ferreira";
            // 
            // lblLinkGit
            // 
            lblLinkGit.AutoSize = true;
            lblLinkGit.Location = new Point(9, 406);
            lblLinkGit.Name = "lblLinkGit";
            lblLinkGit.Size = new Size(130, 15);
            lblLinkGit.TabIndex = 17;
            lblLinkGit.TabStop = true;
            lblLinkGit.Text = "github.com/leandrovip";
            lblLinkGit.LinkClicked += lblLinkGit_LinkClicked;
            // 
            // btnImagem
            // 
            btnImagem.Font = new Font("Verdana", 8.25F);
            btnImagem.Location = new Point(245, 159);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(208, 44);
            btnImagem.TabIndex = 5;
            btnImagem.Text = "Imprimir Imagem";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // txtNormal
            // 
            txtNormal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNormal.Location = new Point(10, 40);
            txtNormal.Name = "txtNormal";
            txtNormal.Size = new Size(141, 23);
            txtNormal.TabIndex = 1;
            txtNormal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNormal
            // 
            lblNormal.AutoSize = true;
            lblNormal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNormal.Location = new Point(7, 22);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(47, 15);
            lblNormal.TabIndex = 0;
            lblNormal.Text = "Normal";
            // 
            // lblCondensado
            // 
            lblCondensado.AutoSize = true;
            lblCondensado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCondensado.Location = new Point(154, 22);
            lblCondensado.Name = "lblCondensado";
            lblCondensado.Size = new Size(74, 15);
            lblCondensado.TabIndex = 2;
            lblCondensado.Text = "Condensado";
            // 
            // txtCondensado
            // 
            txtCondensado.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCondensado.Location = new Point(157, 40);
            txtCondensado.Name = "txtCondensado";
            txtCondensado.Size = new Size(141, 23);
            txtCondensado.TabIndex = 3;
            txtCondensado.TextAlign = HorizontalAlignment.Center;
            // 
            // lblExpandido
            // 
            lblExpandido.AutoSize = true;
            lblExpandido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpandido.Location = new Point(301, 22);
            lblExpandido.Name = "lblExpandido";
            lblExpandido.Size = new Size(63, 15);
            lblExpandido.TabIndex = 4;
            lblExpandido.Text = "Expandido";
            // 
            // txtExpandido
            // 
            txtExpandido.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpandido.Location = new Point(304, 40);
            txtExpandido.Name = "txtExpandido";
            txtExpandido.Size = new Size(131, 23);
            txtExpandido.TabIndex = 5;
            txtExpandido.TextAlign = HorizontalAlignment.Center;
            // 
            // cboProtocolo
            // 
            cboProtocolo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProtocolo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProtocolo.FormattingEnabled = true;
            cboProtocolo.Items.AddRange(new object[] { "Raw", "Network" });
            cboProtocolo.Location = new Point(359, 33);
            cboProtocolo.Name = "cboProtocolo";
            cboProtocolo.Size = new Size(94, 24);
            cboProtocolo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 18);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 15;
            label1.Text = "Protocolo";
            // 
            // gpbColunas
            // 
            gpbColunas.Controls.Add(txtNormal);
            gpbColunas.Controls.Add(lblNormal);
            gpbColunas.Controls.Add(txtCondensado);
            gpbColunas.Controls.Add(lblExpandido);
            gpbColunas.Controls.Add(lblCondensado);
            gpbColunas.Controls.Add(txtExpandido);
            gpbColunas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbColunas.Location = new Point(12, 72);
            gpbColunas.Name = "gpbColunas";
            gpbColunas.Size = new Size(441, 71);
            gpbColunas.TabIndex = 3;
            gpbColunas.TabStop = false;
            gpbColunas.Text = "Configuração de Colunas (Quantidade)";
            // 
            // frmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(465, 435);
            Controls.Add(gpbColunas);
            Controls.Add(cboProtocolo);
            Controls.Add(label1);
            Controls.Add(lblLinkGit);
            Controls.Add(lblDireitos);
            Controls.Add(cboModelo);
            Controls.Add(txtImpressora);
            Controls.Add(lblModelo);
            Controls.Add(lblCaminhoImpressora);
            Controls.Add(btnInicializar);
            Controls.Add(btnCodigoEan13);
            Controls.Add(btnCodigoDeBarras);
            Controls.Add(btnQrCode);
            Controls.Add(btnSair);
            Controls.Add(btnImagem);
            Controls.Add(btnGaveta);
            Controls.Add(btnAutoTeste);
            Controls.Add(btnImprimirTeste);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vip.Printer - Demonstração - .Net 6";
            Load += frmPrincipal_Load;
            gpbColunas.ResumeLayout(false);
            gpbColunas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblCondensado;
        private System.Windows.Forms.TextBox txtCondensado;
        private System.Windows.Forms.Label lblExpandido;
        private System.Windows.Forms.TextBox txtExpandido;
        private System.Windows.Forms.ComboBox cboProtocolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbColunas;
    }
}
