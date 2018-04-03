namespace AMissao
{
    partial class FormPricipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPricipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMovimentoParaCima = new System.Windows.Forms.Button();
            this.btnMovimentoParaBaixo = new System.Windows.Forms.Button();
            this.btnMovimentoEsquerda = new System.Windows.Forms.Button();
            this.btnMovimentoDireita = new System.Windows.Forms.Button();
            this.btnAtaqueDireita = new System.Windows.Forms.Button();
            this.btnAtaqueEsquerda = new System.Windows.Forms.Button();
            this.btnAtaqueParaBaixo = new System.Windows.Forms.Button();
            this.btnAtaqueParaCima = new System.Windows.Forms.Button();
            this.pbxJogador = new System.Windows.Forms.PictureBox();
            this.pbxMorcego = new System.Windows.Forms.PictureBox();
            this.pbxMachado = new System.Windows.Forms.PictureBox();
            this.pbxArco = new System.Windows.Forms.PictureBox();
            this.pbxEspada = new System.Windows.Forms.PictureBox();
            this.pbxPocaoAzul = new System.Windows.Forms.PictureBox();
            this.tlpListaPontos = new System.Windows.Forms.TableLayoutPanel();
            this.lblPontosJogador = new System.Windows.Forms.Label();
            this.lblPontosMorcego = new System.Windows.Forms.Label();
            this.lblPontosFantasma = new System.Windows.Forms.Label();
            this.lblPontosSeifador = new System.Windows.Forms.Label();
            this.lblSeifador = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblFantasma = new System.Windows.Forms.Label();
            this.lblMorcego = new System.Windows.Forms.Label();
            this.pbxFantasma = new System.Windows.Forms.PictureBox();
            this.pbxSeifador = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNivelNumero = new System.Windows.Forms.Label();
            this.pbxInventario1 = new System.Windows.Forms.PictureBox();
            this.pbxInventario3 = new System.Windows.Forms.PictureBox();
            this.pbxInventario2 = new System.Windows.Forms.PictureBox();
            this.pbxInventario4 = new System.Windows.Forms.PictureBox();
            this.pbxPocaoVermelha = new System.Windows.Forms.PictureBox();
            this.pbxInventario5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMorcego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMachado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEspada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPocaoAzul)).BeginInit();
            this.tlpListaPontos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFantasma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeifador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPocaoVermelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ataque";
            // 
            // btnMovimentoParaCima
            // 
            this.btnMovimentoParaCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentoParaCima.Location = new System.Drawing.Point(732, 59);
            this.btnMovimentoParaCima.Name = "btnMovimentoParaCima";
            this.btnMovimentoParaCima.Size = new System.Drawing.Size(104, 27);
            this.btnMovimentoParaCima.TabIndex = 3;
            this.btnMovimentoParaCima.Text = "Para Cima";
            this.btnMovimentoParaCima.UseVisualStyleBackColor = true;
            this.btnMovimentoParaCima.Click += new System.EventHandler(this.btnMovimentoParaCima_Click);
            // 
            // btnMovimentoParaBaixo
            // 
            this.btnMovimentoParaBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentoParaBaixo.Location = new System.Drawing.Point(732, 125);
            this.btnMovimentoParaBaixo.Name = "btnMovimentoParaBaixo";
            this.btnMovimentoParaBaixo.Size = new System.Drawing.Size(104, 27);
            this.btnMovimentoParaBaixo.TabIndex = 4;
            this.btnMovimentoParaBaixo.Text = "Para Baixo";
            this.btnMovimentoParaBaixo.UseVisualStyleBackColor = true;
            this.btnMovimentoParaBaixo.Click += new System.EventHandler(this.btnMovimentoParaBaixo_Click);
            // 
            // btnMovimentoEsquerda
            // 
            this.btnMovimentoEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentoEsquerda.Location = new System.Drawing.Point(687, 92);
            this.btnMovimentoEsquerda.Name = "btnMovimentoEsquerda";
            this.btnMovimentoEsquerda.Size = new System.Drawing.Size(90, 27);
            this.btnMovimentoEsquerda.TabIndex = 5;
            this.btnMovimentoEsquerda.Text = "Esquerda";
            this.btnMovimentoEsquerda.UseVisualStyleBackColor = true;
            this.btnMovimentoEsquerda.Click += new System.EventHandler(this.btnMovimentoEsquerda_Click);
            // 
            // btnMovimentoDireita
            // 
            this.btnMovimentoDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentoDireita.Location = new System.Drawing.Point(779, 92);
            this.btnMovimentoDireita.Name = "btnMovimentoDireita";
            this.btnMovimentoDireita.Size = new System.Drawing.Size(90, 27);
            this.btnMovimentoDireita.TabIndex = 6;
            this.btnMovimentoDireita.Text = "Direita";
            this.btnMovimentoDireita.UseVisualStyleBackColor = true;
            this.btnMovimentoDireita.Click += new System.EventHandler(this.btnMovimentoDireita_Click);
            // 
            // btnAtaqueDireita
            // 
            this.btnAtaqueDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueDireita.Location = new System.Drawing.Point(779, 221);
            this.btnAtaqueDireita.Name = "btnAtaqueDireita";
            this.btnAtaqueDireita.Size = new System.Drawing.Size(90, 27);
            this.btnAtaqueDireita.TabIndex = 10;
            this.btnAtaqueDireita.Text = "Direita";
            this.btnAtaqueDireita.UseVisualStyleBackColor = true;
            this.btnAtaqueDireita.Click += new System.EventHandler(this.btnAtaqueDireita_Click);
            // 
            // btnAtaqueEsquerda
            // 
            this.btnAtaqueEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueEsquerda.Location = new System.Drawing.Point(687, 221);
            this.btnAtaqueEsquerda.Name = "btnAtaqueEsquerda";
            this.btnAtaqueEsquerda.Size = new System.Drawing.Size(90, 27);
            this.btnAtaqueEsquerda.TabIndex = 9;
            this.btnAtaqueEsquerda.Text = "Esquerda";
            this.btnAtaqueEsquerda.UseVisualStyleBackColor = true;
            this.btnAtaqueEsquerda.Click += new System.EventHandler(this.btnAtaqueEsquerda_Click);
            // 
            // btnAtaqueParaBaixo
            // 
            this.btnAtaqueParaBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueParaBaixo.Location = new System.Drawing.Point(732, 254);
            this.btnAtaqueParaBaixo.Name = "btnAtaqueParaBaixo";
            this.btnAtaqueParaBaixo.Size = new System.Drawing.Size(104, 27);
            this.btnAtaqueParaBaixo.TabIndex = 8;
            this.btnAtaqueParaBaixo.Text = "Para Baixo";
            this.btnAtaqueParaBaixo.UseVisualStyleBackColor = true;
            this.btnAtaqueParaBaixo.Click += new System.EventHandler(this.btnAtaqueParaBaixo_Click);
            // 
            // btnAtaqueParaCima
            // 
            this.btnAtaqueParaCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueParaCima.Location = new System.Drawing.Point(732, 188);
            this.btnAtaqueParaCima.Name = "btnAtaqueParaCima";
            this.btnAtaqueParaCima.Size = new System.Drawing.Size(104, 27);
            this.btnAtaqueParaCima.TabIndex = 7;
            this.btnAtaqueParaCima.Text = "Para Cima";
            this.btnAtaqueParaCima.UseVisualStyleBackColor = true;
            this.btnAtaqueParaCima.Click += new System.EventHandler(this.btnAtaqueParaCima_Click);
            // 
            // pbxJogador
            // 
            this.pbxJogador.BackColor = System.Drawing.Color.Transparent;
            this.pbxJogador.Image = ((System.Drawing.Image)(resources.GetObject("pbxJogador.Image")));
            this.pbxJogador.Location = new System.Drawing.Point(83, 58);
            this.pbxJogador.Name = "pbxJogador";
            this.pbxJogador.Size = new System.Drawing.Size(49, 50);
            this.pbxJogador.TabIndex = 16;
            this.pbxJogador.TabStop = false;
            // 
            // pbxMorcego
            // 
            this.pbxMorcego.BackColor = System.Drawing.Color.Transparent;
            this.pbxMorcego.Image = ((System.Drawing.Image)(resources.GetObject("pbxMorcego.Image")));
            this.pbxMorcego.Location = new System.Drawing.Point(138, 58);
            this.pbxMorcego.Name = "pbxMorcego";
            this.pbxMorcego.Size = new System.Drawing.Size(49, 50);
            this.pbxMorcego.TabIndex = 17;
            this.pbxMorcego.TabStop = false;
            // 
            // pbxMachado
            // 
            this.pbxMachado.BackColor = System.Drawing.Color.Transparent;
            this.pbxMachado.Image = ((System.Drawing.Image)(resources.GetObject("pbxMachado.Image")));
            this.pbxMachado.Location = new System.Drawing.Point(358, 59);
            this.pbxMachado.Name = "pbxMachado";
            this.pbxMachado.Size = new System.Drawing.Size(49, 50);
            this.pbxMachado.TabIndex = 18;
            this.pbxMachado.TabStop = false;
            // 
            // pbxArco
            // 
            this.pbxArco.BackColor = System.Drawing.Color.Transparent;
            this.pbxArco.Image = ((System.Drawing.Image)(resources.GetObject("pbxArco.Image")));
            this.pbxArco.Location = new System.Drawing.Point(303, 58);
            this.pbxArco.Name = "pbxArco";
            this.pbxArco.Size = new System.Drawing.Size(49, 50);
            this.pbxArco.TabIndex = 20;
            this.pbxArco.TabStop = false;
            // 
            // pbxEspada
            // 
            this.pbxEspada.BackColor = System.Drawing.Color.Transparent;
            this.pbxEspada.Image = ((System.Drawing.Image)(resources.GetObject("pbxEspada.Image")));
            this.pbxEspada.Location = new System.Drawing.Point(413, 59);
            this.pbxEspada.Name = "pbxEspada";
            this.pbxEspada.Size = new System.Drawing.Size(49, 50);
            this.pbxEspada.TabIndex = 21;
            this.pbxEspada.TabStop = false;
            // 
            // pbxPocaoAzul
            // 
            this.pbxPocaoAzul.BackColor = System.Drawing.Color.Transparent;
            this.pbxPocaoAzul.Image = ((System.Drawing.Image)(resources.GetObject("pbxPocaoAzul.Image")));
            this.pbxPocaoAzul.Location = new System.Drawing.Point(468, 59);
            this.pbxPocaoAzul.Name = "pbxPocaoAzul";
            this.pbxPocaoAzul.Size = new System.Drawing.Size(49, 50);
            this.pbxPocaoAzul.TabIndex = 23;
            this.pbxPocaoAzul.TabStop = false;
            // 
            // tlpListaPontos
            // 
            this.tlpListaPontos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlpListaPontos.ColumnCount = 2;
            this.tlpListaPontos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.51768F));
            this.tlpListaPontos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tlpListaPontos.Controls.Add(this.lblPontosJogador, 1, 0);
            this.tlpListaPontos.Controls.Add(this.lblPontosMorcego, 1, 1);
            this.tlpListaPontos.Controls.Add(this.lblPontosFantasma, 1, 2);
            this.tlpListaPontos.Controls.Add(this.lblPontosSeifador, 1, 3);
            this.tlpListaPontos.Controls.Add(this.lblSeifador, 0, 3);
            this.tlpListaPontos.Controls.Add(this.lblJogador, 0, 0);
            this.tlpListaPontos.Controls.Add(this.lblFantasma, 0, 2);
            this.tlpListaPontos.Controls.Add(this.lblMorcego, 0, 1);
            this.tlpListaPontos.Location = new System.Drawing.Point(632, 320);
            this.tlpListaPontos.Name = "tlpListaPontos";
            this.tlpListaPontos.RowCount = 4;
            this.tlpListaPontos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListaPontos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpListaPontos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpListaPontos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpListaPontos.Size = new System.Drawing.Size(292, 140);
            this.tlpListaPontos.TabIndex = 24;
            // 
            // lblPontosJogador
            // 
            this.lblPontosJogador.AutoSize = true;
            this.lblPontosJogador.Location = new System.Drawing.Point(147, 0);
            this.lblPontosJogador.Name = "lblPontosJogador";
            this.lblPontosJogador.Size = new System.Drawing.Size(81, 13);
            this.lblPontosJogador.TabIndex = 9;
            this.lblPontosJogador.Text = "Pontos Jogador";
            // 
            // lblPontosMorcego
            // 
            this.lblPontosMorcego.AutoSize = true;
            this.lblPontosMorcego.Location = new System.Drawing.Point(147, 39);
            this.lblPontosMorcego.Name = "lblPontosMorcego";
            this.lblPontosMorcego.Size = new System.Drawing.Size(85, 13);
            this.lblPontosMorcego.TabIndex = 11;
            this.lblPontosMorcego.Text = "Pontos Morcego";
            // 
            // lblPontosFantasma
            // 
            this.lblPontosFantasma.AutoSize = true;
            this.lblPontosFantasma.Location = new System.Drawing.Point(147, 76);
            this.lblPontosFantasma.Name = "lblPontosFantasma";
            this.lblPontosFantasma.Size = new System.Drawing.Size(89, 13);
            this.lblPontosFantasma.TabIndex = 13;
            this.lblPontosFantasma.Text = "Pontos Fantasma";
            // 
            // lblPontosSeifador
            // 
            this.lblPontosSeifador.AutoSize = true;
            this.lblPontosSeifador.Location = new System.Drawing.Point(147, 110);
            this.lblPontosSeifador.Name = "lblPontosSeifador";
            this.lblPontosSeifador.Size = new System.Drawing.Size(82, 13);
            this.lblPontosSeifador.TabIndex = 15;
            this.lblPontosSeifador.Text = "Pontos Seifador";
            // 
            // lblSeifador
            // 
            this.lblSeifador.AutoSize = true;
            this.lblSeifador.Location = new System.Drawing.Point(3, 110);
            this.lblSeifador.Name = "lblSeifador";
            this.lblSeifador.Size = new System.Drawing.Size(46, 13);
            this.lblSeifador.TabIndex = 14;
            this.lblSeifador.Text = "Seifador";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(3, 0);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(45, 13);
            this.lblJogador.TabIndex = 8;
            this.lblJogador.Text = "Jogador";
            // 
            // lblFantasma
            // 
            this.lblFantasma.AutoSize = true;
            this.lblFantasma.Location = new System.Drawing.Point(3, 76);
            this.lblFantasma.Name = "lblFantasma";
            this.lblFantasma.Size = new System.Drawing.Size(53, 13);
            this.lblFantasma.TabIndex = 12;
            this.lblFantasma.Text = "Fantasma";
            // 
            // lblMorcego
            // 
            this.lblMorcego.AutoSize = true;
            this.lblMorcego.Location = new System.Drawing.Point(3, 39);
            this.lblMorcego.Name = "lblMorcego";
            this.lblMorcego.Size = new System.Drawing.Size(49, 13);
            this.lblMorcego.TabIndex = 10;
            this.lblMorcego.Text = "Morcego";
            // 
            // pbxFantasma
            // 
            this.pbxFantasma.BackColor = System.Drawing.Color.Transparent;
            this.pbxFantasma.Image = ((System.Drawing.Image)(resources.GetObject("pbxFantasma.Image")));
            this.pbxFantasma.Location = new System.Drawing.Point(193, 58);
            this.pbxFantasma.Name = "pbxFantasma";
            this.pbxFantasma.Size = new System.Drawing.Size(49, 50);
            this.pbxFantasma.TabIndex = 25;
            this.pbxFantasma.TabStop = false;
            // 
            // pbxSeifador
            // 
            this.pbxSeifador.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeifador.Image = ((System.Drawing.Image)(resources.GetObject("pbxSeifador.Image")));
            this.pbxSeifador.Location = new System.Drawing.Point(248, 58);
            this.pbxSeifador.Name = "pbxSeifador";
            this.pbxSeifador.Size = new System.Drawing.Size(49, 50);
            this.pbxSeifador.TabIndex = 26;
            this.pbxSeifador.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nivel";
            // 
            // lblNivelNumero
            // 
            this.lblNivelNumero.AutoSize = true;
            this.lblNivelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelNumero.Location = new System.Drawing.Point(684, 9);
            this.lblNivelNumero.Name = "lblNivelNumero";
            this.lblNivelNumero.Size = new System.Drawing.Size(16, 16);
            this.lblNivelNumero.TabIndex = 1;
            this.lblNivelNumero.Text = "0";
            // 
            // pbxInventario1
            // 
            this.pbxInventario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.pbxInventario1.Enabled = false;
            this.pbxInventario1.Location = new System.Drawing.Point(83, 320);
            this.pbxInventario1.Name = "pbxInventario1";
            this.pbxInventario1.Size = new System.Drawing.Size(50, 50);
            this.pbxInventario1.TabIndex = 28;
            this.pbxInventario1.TabStop = false;
            this.pbxInventario1.Visible = false;
            this.pbxInventario1.Click += new System.EventHandler(this.pbxInventario1_Click);
            // 
            // pbxInventario3
            // 
            this.pbxInventario3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.pbxInventario3.Enabled = false;
            this.pbxInventario3.Location = new System.Drawing.Point(197, 320);
            this.pbxInventario3.Name = "pbxInventario3";
            this.pbxInventario3.Size = new System.Drawing.Size(50, 50);
            this.pbxInventario3.TabIndex = 30;
            this.pbxInventario3.TabStop = false;
            this.pbxInventario3.Visible = false;
            this.pbxInventario3.Click += new System.EventHandler(this.pbxInventario3_Click);
            // 
            // pbxInventario2
            // 
            this.pbxInventario2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.pbxInventario2.Enabled = false;
            this.pbxInventario2.Location = new System.Drawing.Point(141, 320);
            this.pbxInventario2.Name = "pbxInventario2";
            this.pbxInventario2.Size = new System.Drawing.Size(50, 50);
            this.pbxInventario2.TabIndex = 29;
            this.pbxInventario2.TabStop = false;
            this.pbxInventario2.Visible = false;
            this.pbxInventario2.Click += new System.EventHandler(this.pbxInventario2_Click);
            // 
            // pbxInventario4
            // 
            this.pbxInventario4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.pbxInventario4.Enabled = false;
            this.pbxInventario4.Location = new System.Drawing.Point(251, 320);
            this.pbxInventario4.Name = "pbxInventario4";
            this.pbxInventario4.Size = new System.Drawing.Size(50, 50);
            this.pbxInventario4.TabIndex = 31;
            this.pbxInventario4.TabStop = false;
            this.pbxInventario4.Visible = false;
            this.pbxInventario4.Click += new System.EventHandler(this.pbxInventario4_Click);
            // 
            // pbxPocaoVermelha
            // 
            this.pbxPocaoVermelha.BackColor = System.Drawing.Color.Transparent;
            this.pbxPocaoVermelha.Image = ((System.Drawing.Image)(resources.GetObject("pbxPocaoVermelha.Image")));
            this.pbxPocaoVermelha.Location = new System.Drawing.Point(468, 115);
            this.pbxPocaoVermelha.Name = "pbxPocaoVermelha";
            this.pbxPocaoVermelha.Size = new System.Drawing.Size(49, 50);
            this.pbxPocaoVermelha.TabIndex = 32;
            this.pbxPocaoVermelha.TabStop = false;
            // 
            // pbxInventario5
            // 
            this.pbxInventario5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.pbxInventario5.Enabled = false;
            this.pbxInventario5.Location = new System.Drawing.Point(307, 320);
            this.pbxInventario5.Name = "pbxInventario5";
            this.pbxInventario5.Size = new System.Drawing.Size(50, 50);
            this.pbxInventario5.TabIndex = 33;
            this.pbxInventario5.TabStop = false;
            this.pbxInventario5.Visible = false;
            this.pbxInventario5.Click += new System.EventHandler(this.pbxInventario5_Click);
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 468);
            this.Controls.Add(this.pbxInventario5);
            this.Controls.Add(this.pbxPocaoVermelha);
            this.Controls.Add(this.pbxInventario1);
            this.Controls.Add(this.pbxInventario3);
            this.Controls.Add(this.pbxInventario2);
            this.Controls.Add(this.pbxInventario4);
            this.Controls.Add(this.lblNivelNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxSeifador);
            this.Controls.Add(this.pbxFantasma);
            this.Controls.Add(this.tlpListaPontos);
            this.Controls.Add(this.pbxPocaoAzul);
            this.Controls.Add(this.pbxEspada);
            this.Controls.Add(this.pbxArco);
            this.Controls.Add(this.pbxMachado);
            this.Controls.Add(this.btnAtaqueDireita);
            this.Controls.Add(this.pbxMorcego);
            this.Controls.Add(this.btnAtaqueEsquerda);
            this.Controls.Add(this.btnAtaqueParaBaixo);
            this.Controls.Add(this.pbxJogador);
            this.Controls.Add(this.btnAtaqueParaCima);
            this.Controls.Add(this.btnMovimentoDireita);
            this.Controls.Add(this.btnMovimentoEsquerda);
            this.Controls.Add(this.btnMovimentoParaBaixo);
            this.Controls.Add(this.btnMovimentoParaCima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPricipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Missão";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMorcego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMachado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEspada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPocaoAzul)).EndInit();
            this.tlpListaPontos.ResumeLayout(false);
            this.tlpListaPontos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFantasma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeifador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPocaoVermelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInventario5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMovimentoParaCima;
        private System.Windows.Forms.Button btnMovimentoParaBaixo;
        private System.Windows.Forms.Button btnMovimentoEsquerda;
        private System.Windows.Forms.Button btnMovimentoDireita;
        private System.Windows.Forms.Button btnAtaqueDireita;
        private System.Windows.Forms.Button btnAtaqueEsquerda;
        private System.Windows.Forms.Button btnAtaqueParaBaixo;
        private System.Windows.Forms.Button btnAtaqueParaCima;
        private System.Windows.Forms.PictureBox pbxJogador;
        private System.Windows.Forms.PictureBox pbxMorcego;
        private System.Windows.Forms.PictureBox pbxMachado;
        private System.Windows.Forms.PictureBox pbxArco;
        private System.Windows.Forms.PictureBox pbxEspada;
        private System.Windows.Forms.PictureBox pbxPocaoAzul;
        private System.Windows.Forms.TableLayoutPanel tlpListaPontos;
        private System.Windows.Forms.PictureBox pbxFantasma;
        private System.Windows.Forms.PictureBox pbxSeifador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNivelNumero;
        private System.Windows.Forms.PictureBox pbxInventario1;
        private System.Windows.Forms.PictureBox pbxInventario3;
        private System.Windows.Forms.PictureBox pbxInventario2;
        private System.Windows.Forms.PictureBox pbxInventario4;
        private System.Windows.Forms.Label lblPontosJogador;
        private System.Windows.Forms.Label lblPontosMorcego;
        private System.Windows.Forms.Label lblPontosFantasma;
        private System.Windows.Forms.Label lblPontosSeifador;
        private System.Windows.Forms.Label lblSeifador;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblFantasma;
        private System.Windows.Forms.Label lblMorcego;
        private System.Windows.Forms.PictureBox pbxPocaoVermelha;
        private System.Windows.Forms.PictureBox pbxInventario5;
    }
}

