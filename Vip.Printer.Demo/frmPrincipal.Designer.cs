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
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(725, 439);
            this.Controls.Add(this.btnImprimirTeste);
            this.Name = "frmPrincipal";
            this.Text = "Vip.Printer - Demonstração";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirTeste;
    }
}