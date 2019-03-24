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
			this.SuspendLayout();
			// 
			// btnImprimirTeste
			// 
			this.btnImprimirTeste.Location = new System.Drawing.Point(12, 12);
			this.btnImprimirTeste.Name = "btnImprimirTeste";
			this.btnImprimirTeste.Size = new System.Drawing.Size(133, 44);
			this.btnImprimirTeste.TabIndex = 0;
			this.btnImprimirTeste.Text = "Imprimir Teste";
			this.btnImprimirTeste.UseVisualStyleBackColor = true;
			this.btnImprimirTeste.Click += new System.EventHandler(this.btnTexto_Click);
			// 
			// btnGaveta
			// 
			this.btnGaveta.Location = new System.Drawing.Point(151, 12);
			this.btnGaveta.Name = "btnGaveta";
			this.btnGaveta.Size = new System.Drawing.Size(133, 44);
			this.btnGaveta.TabIndex = 0;
			this.btnGaveta.Text = "Abrir Gaveta";
			this.btnGaveta.UseVisualStyleBackColor = true;
			this.btnGaveta.Click += new System.EventHandler(this.btnGaveta_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(151, 252);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(133, 44);
			this.btnSair.TabIndex = 1;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnQrCode
			// 
			this.btnQrCode.Location = new System.Drawing.Point(12, 62);
			this.btnQrCode.Name = "btnQrCode";
			this.btnQrCode.Size = new System.Drawing.Size(133, 44);
			this.btnQrCode.TabIndex = 2;
			this.btnQrCode.Text = "Imprimir QrCode";
			this.btnQrCode.UseVisualStyleBackColor = true;
			this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
			// 
			// btnCodigoDeBarras
			// 
			this.btnCodigoDeBarras.Location = new System.Drawing.Point(152, 62);
			this.btnCodigoDeBarras.Name = "btnCodigoDeBarras";
			this.btnCodigoDeBarras.Size = new System.Drawing.Size(133, 44);
			this.btnCodigoDeBarras.TabIndex = 2;
			this.btnCodigoDeBarras.Text = "Imprimir Código de Barras";
			this.btnCodigoDeBarras.UseVisualStyleBackColor = true;
			this.btnCodigoDeBarras.Click += new System.EventHandler(this.btnCodigoDeBarras_Click);
			// 
			// btnCodigoEan13
			// 
			this.btnCodigoEan13.Location = new System.Drawing.Point(12, 112);
			this.btnCodigoEan13.Name = "btnCodigoEan13";
			this.btnCodigoEan13.Size = new System.Drawing.Size(133, 44);
			this.btnCodigoEan13.TabIndex = 3;
			this.btnCodigoEan13.Text = "Imprimir Código de Barras EAN13";
			this.btnCodigoEan13.UseVisualStyleBackColor = true;
			this.btnCodigoEan13.Click += new System.EventHandler(this.btnCodigoEan13_Click);
			// 
			// btnInicializar
			// 
			this.btnInicializar.Location = new System.Drawing.Point(151, 112);
			this.btnInicializar.Name = "btnInicializar";
			this.btnInicializar.Size = new System.Drawing.Size(133, 44);
			this.btnInicializar.TabIndex = 4;
			this.btnInicializar.Text = "Inicializar Impressora (Reset)";
			this.btnInicializar.UseVisualStyleBackColor = true;
			this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(297, 308);
			this.Controls.Add(this.btnInicializar);
			this.Controls.Add(this.btnCodigoEan13);
			this.Controls.Add(this.btnCodigoDeBarras);
			this.Controls.Add(this.btnQrCode);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnGaveta);
			this.Controls.Add(this.btnImprimirTeste);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrincipal";
			this.Text = "Vip.Printer - Demonstração";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirTeste;
		private System.Windows.Forms.Button btnGaveta;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnQrCode;
		private System.Windows.Forms.Button btnCodigoDeBarras;
		private System.Windows.Forms.Button btnCodigoEan13;
        private System.Windows.Forms.Button btnInicializar;
    }
}