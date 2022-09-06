namespace aula5
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
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.txtatual = new System.Windows.Forms.TextBox();
            this.txtnasc = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbAnoNasc = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picimagem
            // 
            this.picimagem.BackColor = System.Drawing.Color.Transparent;
            this.picimagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picimagem.Location = new System.Drawing.Point(731, 48);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(302, 236);
            this.picimagem.TabIndex = 0;
            this.picimagem.TabStop = false;
            this.picimagem.Click += new System.EventHandler(this.Picimagem_Click);
            // 
            // txtatual
            // 
            this.txtatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatual.Location = new System.Drawing.Point(310, 73);
            this.txtatual.Name = "txtatual";
            this.txtatual.Size = new System.Drawing.Size(366, 40);
            this.txtatual.TabIndex = 1;
            this.txtatual.TextChanged += new System.EventHandler(this.Txtatual_TextChanged);
            // 
            // txtnasc
            // 
            this.txtnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(310, 149);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(366, 40);
            this.txtnasc.TabIndex = 2;
            this.txtnasc.TextChanged += new System.EventHandler(this.Txtnasc_TextChanged);
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(310, 227);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(366, 40);
            this.txtidade.TabIndex = 3;
            this.txtidade.TextChanged += new System.EventHandler(this.Txtidade_TextChanged);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.BackColor = System.Drawing.Color.Transparent;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAno.Location = new System.Drawing.Point(121, 80);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(155, 33);
            this.lbAno.TabIndex = 4;
            this.lbAno.Text = "Ano atual:";
            this.lbAno.Click += new System.EventHandler(this.LbAno_Click);
            // 
            // lbAnoNasc
            // 
            this.lbAnoNasc.AutoSize = true;
            this.lbAnoNasc.BackColor = System.Drawing.Color.Transparent;
            this.lbAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnoNasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnoNasc.Location = new System.Drawing.Point(24, 149);
            this.lbAnoNasc.Name = "lbAnoNasc";
            this.lbAnoNasc.Size = new System.Drawing.Size(252, 33);
            this.lbAnoNasc.TabIndex = 5;
            this.lbAnoNasc.Text = "Ano Nascimento:";
            this.lbAnoNasc.Click += new System.EventHandler(this.LbAnoNasc_Click);
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.BackColor = System.Drawing.Color.Transparent;
            this.lbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIdade.Location = new System.Drawing.Point(175, 234);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(101, 33);
            this.lbIdade.TabIndex = 6;
            this.lbIdade.Text = "Idade:";
            this.lbIdade.Click += new System.EventHandler(this.LbIdade_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.BackColor = System.Drawing.Color.Transparent;
            this.botaoCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.botaoCalcular.Location = new System.Drawing.Point(264, 402);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(278, 98);
            this.botaoCalcular.TabIndex = 7;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = false;
            this.botaoCalcular.Click += new System.EventHandler(this.BotaoCalcular_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.Color.Transparent;
            this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoLimpar.Location = new System.Drawing.Point(585, 402);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(265, 98);
            this.botaoLimpar.TabIndex = 8;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.Location = new System.Drawing.Point(725, 307);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(42, 33);
            this.lbMensagem.TabIndex = 9;
            this.lbMensagem.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::aula5.Properties.Resources.High_resolution_wallpaper_background_ID_77700354074;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 570);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbAnoNasc);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnasc);
            this.Controls.Add(this.txtatual);
            this.Controls.Add(this.picimagem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.TextBox txtatual;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbAnoNasc;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Label lbMensagem;
    }
}

