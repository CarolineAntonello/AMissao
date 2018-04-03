namespace AMissao
{
    partial class FormGanhou
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
            this.btFechar = new System.Windows.Forms.Button();
            this.btNovoJogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(33, 129);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(107, 35);
            this.btFechar.TabIndex = 7;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btNovoJogo
            // 
            this.btNovoJogo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoJogo.Location = new System.Drawing.Point(169, 129);
            this.btNovoJogo.Margin = new System.Windows.Forms.Padding(2);
            this.btNovoJogo.Name = "btNovoJogo";
            this.btNovoJogo.Size = new System.Drawing.Size(107, 35);
            this.btNovoJogo.TabIndex = 6;
            this.btNovoJogo.Text = "Novo Jogo";
            this.btNovoJogo.UseVisualStyleBackColor = true;
            this.btNovoJogo.Click += new System.EventHandler(this.btNovoJogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parabéns";
            // 
            // FormGanhou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btNovoJogo);
            this.Name = "FormGanhou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGanhou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btNovoJogo;
        private System.Windows.Forms.Label label1;
    }
}