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
			this.btnSair.Location = new System.Drawing.Point(258, 252);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(133, 44);
			this.btnSair.TabIndex = 1;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(403, 308);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnGaveta);
			this.Controls.Add(this.btnImprimirTeste);
			this.Name = "frmPrincipal";
			this.Text = "Vip.Printer - Demonstração";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirTeste;
		private System.Windows.Forms.Button btnGaveta;
		private System.Windows.Forms.Button btnSair;
	}
}