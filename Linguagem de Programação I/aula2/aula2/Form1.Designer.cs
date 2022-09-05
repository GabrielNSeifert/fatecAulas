namespace aula2
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
            this.botaoSomar = new System.Windows.Forms.Button();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.resultadoText = new System.Windows.Forms.TextBox();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoSomar
            // 
            this.botaoSomar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSomar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoSomar.Location = new System.Drawing.Point(196, 456);
            this.botaoSomar.Name = "botaoSomar";
            this.botaoSomar.Size = new System.Drawing.Size(323, 117);
            this.botaoSomar.TabIndex = 0;
            this.botaoSomar.Text = "Somar";
            this.botaoSomar.UseVisualStyleBackColor = false;
            this.botaoSomar.Click += new System.EventHandler(this.botaoSomar_Click);
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotaoLimpar.Location = new System.Drawing.Point(625, 456);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(323, 117);
            this.BotaoLimpar.TabIndex = 1;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = false;
            this.BotaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // numero2
            // 
            this.numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(578, 280);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(329, 31);
            this.numero2.TabIndex = 3;
            // 
            // resultadoText
            // 
            this.resultadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoText.Location = new System.Drawing.Point(578, 374);
            this.resultadoText.Name = "resultadoText";
            this.resultadoText.Size = new System.Drawing.Size(329, 31);
            this.resultadoText.TabIndex = 4;
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero1.Location = new System.Drawing.Point(245, 188);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(274, 25);
            this.labelNumero1.TabIndex = 5;
            this.labelNumero1.Text = "Insira o primeiro número:";
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero2.Location = new System.Drawing.Point(245, 278);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(279, 25);
            this.labelNumero2.TabIndex = 6;
            this.labelNumero2.Text = "Insira o segundo número:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(245, 368);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(125, 25);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Resultado:";
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(578, 188);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(329, 31);
            this.numero1.TabIndex = 8;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(237, 55);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(629, 73);
            this.Titulo.TabIndex = 9;
            this.Titulo.Text = "Some dois Números";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 658);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.resultadoText);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.botaoSomar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoSomar;
        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox resultadoText;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Label Titulo;
    }
}

