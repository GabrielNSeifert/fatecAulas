namespace exercicio1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbVelocidade = new System.Windows.Forms.Label();
            this.lbDiametro = new System.Windows.Forms.Label();
            this.lbViscosidade = new System.Windows.Forms.Label();
            this.lbNr = new System.Windows.Forms.Label();
            this.lbDensidade = new System.Windows.Forms.Label();
            this.densidade = new System.Windows.Forms.TextBox();
            this.velocidade = new System.Windows.Forms.TextBox();
            this.diametro = new System.Windows.Forms.TextBox();
            this.viscosidade = new System.Windows.Forms.TextBox();
            this.nr = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formula de Reynolds";
            // 
            // lbVelocidade
            // 
            this.lbVelocidade.AutoSize = true;
            this.lbVelocidade.BackColor = System.Drawing.Color.Transparent;
            this.lbVelocidade.ForeColor = System.Drawing.Color.Transparent;
            this.lbVelocidade.Location = new System.Drawing.Point(38, 210);
            this.lbVelocidade.Name = "lbVelocidade";
            this.lbVelocidade.Size = new System.Drawing.Size(275, 55);
            this.lbVelocidade.TabIndex = 2;
            this.lbVelocidade.Text = "Velocidade:";
            // 
            // lbDiametro
            // 
            this.lbDiametro.AutoSize = true;
            this.lbDiametro.BackColor = System.Drawing.Color.Transparent;
            this.lbDiametro.ForeColor = System.Drawing.Color.Transparent;
            this.lbDiametro.Location = new System.Drawing.Point(38, 288);
            this.lbDiametro.Name = "lbDiametro";
            this.lbDiametro.Size = new System.Drawing.Size(232, 55);
            this.lbDiametro.TabIndex = 3;
            this.lbDiametro.Text = "Diâmetro:";
            // 
            // lbViscosidade
            // 
            this.lbViscosidade.AutoSize = true;
            this.lbViscosidade.BackColor = System.Drawing.Color.Transparent;
            this.lbViscosidade.ForeColor = System.Drawing.Color.Transparent;
            this.lbViscosidade.Location = new System.Drawing.Point(38, 375);
            this.lbViscosidade.Name = "lbViscosidade";
            this.lbViscosidade.Size = new System.Drawing.Size(296, 55);
            this.lbViscosidade.TabIndex = 4;
            this.lbViscosidade.Text = "Viscosidade:";
            // 
            // lbNr
            // 
            this.lbNr.AutoSize = true;
            this.lbNr.BackColor = System.Drawing.Color.Transparent;
            this.lbNr.ForeColor = System.Drawing.Color.Transparent;
            this.lbNr.Location = new System.Drawing.Point(38, 460);
            this.lbNr.Name = "lbNr";
            this.lbNr.Size = new System.Drawing.Size(107, 55);
            this.lbNr.TabIndex = 5;
            this.lbNr.Text = "NR:";
            // 
            // lbDensidade
            // 
            this.lbDensidade.AutoSize = true;
            this.lbDensidade.BackColor = System.Drawing.Color.Transparent;
            this.lbDensidade.ForeColor = System.Drawing.Color.Transparent;
            this.lbDensidade.Location = new System.Drawing.Point(38, 130);
            this.lbDensidade.Name = "lbDensidade";
            this.lbDensidade.Size = new System.Drawing.Size(268, 55);
            this.lbDensidade.TabIndex = 6;
            this.lbDensidade.Text = "Densidade:\r\n";
            // 
            // densidade
            // 
            this.densidade.Location = new System.Drawing.Point(390, 130);
            this.densidade.Name = "densidade";
            this.densidade.Size = new System.Drawing.Size(336, 62);
            this.densidade.TabIndex = 7;
            // 
            // velocidade
            // 
            this.velocidade.Location = new System.Drawing.Point(390, 210);
            this.velocidade.Name = "velocidade";
            this.velocidade.Size = new System.Drawing.Size(336, 62);
            this.velocidade.TabIndex = 8;
            // 
            // diametro
            // 
            this.diametro.Location = new System.Drawing.Point(390, 288);
            this.diametro.Name = "diametro";
            this.diametro.Size = new System.Drawing.Size(336, 62);
            this.diametro.TabIndex = 9;
            // 
            // viscosidade
            // 
            this.viscosidade.Location = new System.Drawing.Point(390, 375);
            this.viscosidade.Name = "viscosidade";
            this.viscosidade.Size = new System.Drawing.Size(336, 62);
            this.viscosidade.TabIndex = 10;
            // 
            // nr
            // 
            this.nr.Location = new System.Drawing.Point(390, 460);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(336, 62);
            this.nr.TabIndex = 11;
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Transparent;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcular.Location = new System.Drawing.Point(312, 548);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(235, 67);
            this.calcular.TabIndex = 12;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.Transparent;
            this.limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpar.Location = new System.Drawing.Point(594, 548);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(235, 67);
            this.limpar.TabIndex = 13;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.Transparent;
            this.imagem.Location = new System.Drawing.Point(817, 139);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(274, 366);
            this.imagem.TabIndex = 14;
            this.imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::exercicio1.Properties.Resources.High_resolution_wallpaper_background_ID_77700354074;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 649);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.viscosidade);
            this.Controls.Add(this.diametro);
            this.Controls.Add(this.velocidade);
            this.Controls.Add(this.densidade);
            this.Controls.Add(this.lbDensidade);
            this.Controls.Add(this.lbNr);
            this.Controls.Add(this.lbViscosidade);
            this.Controls.Add(this.lbDiametro);
            this.Controls.Add(this.lbVelocidade);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVelocidade;
        private System.Windows.Forms.Label lbDiametro;
        private System.Windows.Forms.Label lbViscosidade;
        private System.Windows.Forms.Label lbNr;
        private System.Windows.Forms.Label lbDensidade;
        private System.Windows.Forms.TextBox densidade;
        private System.Windows.Forms.TextBox velocidade;
        private System.Windows.Forms.TextBox diametro;
        private System.Windows.Forms.TextBox viscosidade;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.PictureBox imagem;
    }
}

