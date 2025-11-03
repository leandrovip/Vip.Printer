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
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblCondensado = new System.Windows.Forms.Label();
            this.txtCondensado = new System.Windows.Forms.TextBox();
            this.lblExpandido = new System.Windows.Forms.Label();
            this.txtExpandido = new System.Windows.Forms.TextBox();
            this.cboProtocolo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbColunas = new System.Windows.Forms.GroupBox();
            this.gpbSerial = new System.Windows.Forms.GroupBox();
            this.txtBaudeRate = new System.Windows.Forms.TextBox();
            this.lblBaudeRate = new System.Windows.Forms.Label();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cboHandShake = new System.Windows.Forms.ComboBox();
            this.lblHandShake = new System.Windows.Forms.Label();
            this.gpbColunas.SuspendLayout();
            this.gpbSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimirTeste
            // 
            this.btnImprimirTeste.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnImprimirTeste.Location = new System.Drawing.Point(12, 226);
            this.btnImprimirTeste.Name = "btnImprimirTeste";
            this.btnImprimirTeste.Size = new System.Drawing.Size(209, 44);
            this.btnImprimirTeste.TabIndex = 4;
            this.btnImprimirTeste.Text = "Imprimir Teste";
            this.btnImprimirTeste.UseVisualStyleBackColor = true;
            this.btnImprimirTeste.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnGaveta
            // 
            this.btnGaveta.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnGaveta.Location = new System.Drawing.Point(245, 276);
            this.btnGaveta.Name = "btnGaveta";
            this.btnGaveta.Size = new System.Drawing.Size(208, 44);
            this.btnGaveta.TabIndex = 7;
            this.btnGaveta.Text = "Abrir Gaveta";
            this.btnGaveta.UseVisualStyleBackColor = true;
            this.btnGaveta.Click += new System.EventHandler(this.btnGaveta_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(245, 436);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(208, 44);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnQrCode
            // 
            this.btnQrCode.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnQrCode.Location = new System.Drawing.Point(12, 276);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Size = new System.Drawing.Size(209, 44);
            this.btnQrCode.TabIndex = 6;
            this.btnQrCode.Text = "Imprimir QrCode";
            this.btnQrCode.UseVisualStyleBackColor = true;
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // btnCodigoDeBarras
            // 
            this.btnCodigoDeBarras.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnCodigoDeBarras.Location = new System.Drawing.Point(245, 326);
            this.btnCodigoDeBarras.Name = "btnCodigoDeBarras";
            this.btnCodigoDeBarras.Size = new System.Drawing.Size(208, 44);
            this.btnCodigoDeBarras.TabIndex = 9;
            this.btnCodigoDeBarras.Text = "Imprimir Código de Barras";
            this.btnCodigoDeBarras.UseVisualStyleBackColor = true;
            this.btnCodigoDeBarras.Click += new System.EventHandler(this.btnCodigoDeBarras_Click);
            // 
            // btnCodigoEan13
            // 
            this.btnCodigoEan13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnCodigoEan13.Location = new System.Drawing.Point(12, 326);
            this.btnCodigoEan13.Name = "btnCodigoEan13";
            this.btnCodigoEan13.Size = new System.Drawing.Size(209, 44);
            this.btnCodigoEan13.TabIndex = 8;
            this.btnCodigoEan13.Text = "Imprimir Código de Barras EAN13";
            this.btnCodigoEan13.UseVisualStyleBackColor = true;
            this.btnCodigoEan13.Click += new System.EventHandler(this.btnCodigoEan13_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnInicializar.Location = new System.Drawing.Point(245, 376);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(208, 44);
            this.btnInicializar.TabIndex = 11;
            this.btnInicializar.Text = "Inicializar Impressora (Reset)";
            this.btnInicializar.UseVisualStyleBackColor = false;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // lblCaminhoImpressora
            // 
            this.lblCaminhoImpressora.AutoSize = true;
            this.lblCaminhoImpressora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoImpressora.Location = new System.Drawing.Point(9, 18);
            this.lblCaminhoImpressora.Name = "lblCaminhoImpressora";
            this.lblCaminhoImpressora.Size = new System.Drawing.Size(218, 15);
            this.lblCaminhoImpressora.TabIndex = 13;
            this.lblCaminhoImpressora.Text = "Caminho, nome ou porta da impressora";
            // 
            // txtImpressora
            // 
            this.txtImpressora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpressora.Location = new System.Drawing.Point(12, 34);
            this.txtImpressora.Name = "txtImpressora";
            this.txtImpressora.Size = new System.Drawing.Size(233, 23);
            this.txtImpressora.TabIndex = 0;
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
            this.cboModelo.Location = new System.Drawing.Point(251, 33);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(102, 24);
            this.cboModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(248, 18);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(105, 15);
            this.lblModelo.TabIndex = 14;
            this.lblModelo.Text = "Modelo Impressão";
            // 
            // btnAutoTeste
            // 
            this.btnAutoTeste.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnAutoTeste.Location = new System.Drawing.Point(12, 376);
            this.btnAutoTeste.Name = "btnAutoTeste";
            this.btnAutoTeste.Size = new System.Drawing.Size(209, 44);
            this.btnAutoTeste.TabIndex = 10;
            this.btnAutoTeste.Text = "Imprimir Auto Teste";
            this.btnAutoTeste.UseVisualStyleBackColor = true;
            this.btnAutoTeste.Click += new System.EventHandler(this.btnAutoTeste_Click);
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.Location = new System.Drawing.Point(9, 444);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(165, 15);
            this.lblDireitos.TabIndex = 16;
            this.lblDireitos.Text = "Develop by Leandro Ferreira";
            // 
            // lblLinkGit
            // 
            this.lblLinkGit.AutoSize = true;
            this.lblLinkGit.Location = new System.Drawing.Point(9, 465);
            this.lblLinkGit.Name = "lblLinkGit";
            this.lblLinkGit.Size = new System.Drawing.Size(130, 15);
            this.lblLinkGit.TabIndex = 17;
            this.lblLinkGit.TabStop = true;
            this.lblLinkGit.Text = "github.com/leandrovip";
            this.lblLinkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGit_LinkClicked);
            // 
            // btnImagem
            // 
            this.btnImagem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnImagem.Location = new System.Drawing.Point(245, 226);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(208, 44);
            this.btnImagem.TabIndex = 5;
            this.btnImagem.Text = "Imprimir Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // txtNormal
            // 
            this.txtNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNormal.Location = new System.Drawing.Point(10, 40);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(141, 23);
            this.txtNormal.TabIndex = 1;
            this.txtNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(7, 22);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(47, 15);
            this.lblNormal.TabIndex = 0;
            this.lblNormal.Text = "Normal";
            // 
            // lblCondensado
            // 
            this.lblCondensado.AutoSize = true;
            this.lblCondensado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondensado.Location = new System.Drawing.Point(154, 22);
            this.lblCondensado.Name = "lblCondensado";
            this.lblCondensado.Size = new System.Drawing.Size(74, 15);
            this.lblCondensado.TabIndex = 2;
            this.lblCondensado.Text = "Condensado";
            // 
            // txtCondensado
            // 
            this.txtCondensado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondensado.Location = new System.Drawing.Point(157, 40);
            this.txtCondensado.Name = "txtCondensado";
            this.txtCondensado.Size = new System.Drawing.Size(141, 23);
            this.txtCondensado.TabIndex = 3;
            this.txtCondensado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExpandido
            // 
            this.lblExpandido.AutoSize = true;
            this.lblExpandido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpandido.Location = new System.Drawing.Point(301, 22);
            this.lblExpandido.Name = "lblExpandido";
            this.lblExpandido.Size = new System.Drawing.Size(62, 15);
            this.lblExpandido.TabIndex = 4;
            this.lblExpandido.Text = "Expandido";
            // 
            // txtExpandido
            // 
            this.txtExpandido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpandido.Location = new System.Drawing.Point(304, 40);
            this.txtExpandido.Name = "txtExpandido";
            this.txtExpandido.Size = new System.Drawing.Size(131, 23);
            this.txtExpandido.TabIndex = 5;
            this.txtExpandido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboProtocolo
            // 
            this.cboProtocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProtocolo.FormattingEnabled = true;
            this.cboProtocolo.Items.AddRange(new object[] {
            "Raw",
            "Network",
            "Serial"});
            this.cboProtocolo.Location = new System.Drawing.Point(359, 33);
            this.cboProtocolo.Name = "cboProtocolo";
            this.cboProtocolo.Size = new System.Drawing.Size(94, 24);
            this.cboProtocolo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Protocolo";
            // 
            // gpbColunas
            // 
            this.gpbColunas.Controls.Add(this.txtNormal);
            this.gpbColunas.Controls.Add(this.lblNormal);
            this.gpbColunas.Controls.Add(this.txtCondensado);
            this.gpbColunas.Controls.Add(this.lblExpandido);
            this.gpbColunas.Controls.Add(this.lblCondensado);
            this.gpbColunas.Controls.Add(this.txtExpandido);
            this.gpbColunas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbColunas.Location = new System.Drawing.Point(12, 72);
            this.gpbColunas.Name = "gpbColunas";
            this.gpbColunas.Size = new System.Drawing.Size(441, 71);
            this.gpbColunas.TabIndex = 3;
            this.gpbColunas.TabStop = false;
            this.gpbColunas.Text = "Configuração de Colunas (Quantidade)";
            // 
            // gpbSerial
            // 
            this.gpbSerial.Controls.Add(this.cboHandShake);
            this.gpbSerial.Controls.Add(this.lblHandShake);
            this.gpbSerial.Controls.Add(this.cboStopBits);
            this.gpbSerial.Controls.Add(this.lblStopBits);
            this.gpbSerial.Controls.Add(this.cboParity);
            this.gpbSerial.Controls.Add(this.lblParity);
            this.gpbSerial.Controls.Add(this.txtBaudeRate);
            this.gpbSerial.Controls.Add(this.lblBaudeRate);
            this.gpbSerial.Controls.Add(this.txtDataBits);
            this.gpbSerial.Controls.Add(this.lblDataBits);
            this.gpbSerial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSerial.Location = new System.Drawing.Point(12, 149);
            this.gpbSerial.Name = "gpbSerial";
            this.gpbSerial.Size = new System.Drawing.Size(441, 71);
            this.gpbSerial.TabIndex = 18;
            this.gpbSerial.TabStop = false;
            this.gpbSerial.Text = "Configurações Serial";
            // 
            // txtBaudeRate
            // 
            this.txtBaudeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaudeRate.Location = new System.Drawing.Point(10, 40);
            this.txtBaudeRate.Name = "txtBaudeRate";
            this.txtBaudeRate.Size = new System.Drawing.Size(66, 23);
            this.txtBaudeRate.TabIndex = 1;
            this.txtBaudeRate.Text = "9600";
            this.txtBaudeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBaudeRate
            // 
            this.lblBaudeRate.AutoSize = true;
            this.lblBaudeRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudeRate.Location = new System.Drawing.Point(7, 22);
            this.lblBaudeRate.Name = "lblBaudeRate";
            this.lblBaudeRate.Size = new System.Drawing.Size(66, 15);
            this.lblBaudeRate.TabIndex = 0;
            this.lblBaudeRate.Text = "Baude Rate";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBits.Location = new System.Drawing.Point(82, 40);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(47, 23);
            this.txtDataBits.TabIndex = 3;
            this.txtDataBits.Text = "8";
            this.txtDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBits.Location = new System.Drawing.Point(79, 22);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(50, 15);
            this.lblDataBits.TabIndex = 2;
            this.lblDataBits.Text = "DataBits";
            // 
            // cboParity
            // 
            this.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cboParity.Location = new System.Drawing.Point(135, 39);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(74, 24);
            this.cboParity.TabIndex = 15;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(132, 22);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(37, 15);
            this.lblParity.TabIndex = 16;
            this.lblParity.Text = "Parity";
            // 
            // cboStopBits
            // 
            this.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive",
            "None"});
            this.cboStopBits.Location = new System.Drawing.Point(215, 39);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(83, 24);
            this.cboStopBits.TabIndex = 17;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBits.Location = new System.Drawing.Point(212, 22);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(50, 15);
            this.lblStopBits.TabIndex = 18;
            this.lblStopBits.Text = "StopBits";
            // 
            // cboHandShake
            // 
            this.cboHandShake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHandShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHandShake.FormattingEnabled = true;
            this.cboHandShake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cboHandShake.Location = new System.Drawing.Point(304, 39);
            this.cboHandShake.Name = "cboHandShake";
            this.cboHandShake.Size = new System.Drawing.Size(131, 24);
            this.cboHandShake.TabIndex = 19;
            // 
            // lblHandShake
            // 
            this.lblHandShake.AutoSize = true;
            this.lblHandShake.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandShake.Location = new System.Drawing.Point(301, 22);
            this.lblHandShake.Name = "lblHandShake";
            this.lblHandShake.Size = new System.Drawing.Size(67, 15);
            this.lblHandShake.TabIndex = 20;
            this.lblHandShake.Text = "HandShake";
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(465, 491);
            this.Controls.Add(this.gpbSerial);
            this.Controls.Add(this.gpbColunas);
            this.Controls.Add(this.cboProtocolo);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vip.Printer - Demonstração - .Net 4.6.2";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpbColunas.ResumeLayout(false);
            this.gpbColunas.PerformLayout();
            this.gpbSerial.ResumeLayout(false);
            this.gpbSerial.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblCondensado;
        private System.Windows.Forms.TextBox txtCondensado;
        private System.Windows.Forms.Label lblExpandido;
        private System.Windows.Forms.TextBox txtExpandido;
        private System.Windows.Forms.ComboBox cboProtocolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbColunas;
        private System.Windows.Forms.GroupBox gpbSerial;
        private System.Windows.Forms.TextBox txtBaudeRate;
        private System.Windows.Forms.Label lblBaudeRate;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cboHandShake;
        private System.Windows.Forms.Label lblHandShake;
    }
}