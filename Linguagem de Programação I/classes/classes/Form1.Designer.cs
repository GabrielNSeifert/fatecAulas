namespace classes
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
            this.btquadrado = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btretangulo = new System.Windows.Forms.Button();
            this.bttriangulo = new System.Windows.Forms.Button();
            this.bttrapezio = new System.Windows.Forms.Button();
            this.txtbma = new System.Windows.Forms.TextBox();
            this.txtbme = new System.Windows.Forms.TextBox();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.ba = new System.Windows.Forms.Label();
            this.bm = new System.Windows.Forms.Label();
            this.alt = new System.Windows.Forms.Label();
            this.btfatorial = new System.Windows.Forms.Button();
            this.btfuck = new System.Windows.Forms.Button();
            this.txtfuck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btquadrado
            // 
            this.btquadrado.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquadrado.Location = new System.Drawing.Point(17, 12);
            this.btquadrado.Name = "btquadrado";
            this.btquadrado.Size = new System.Drawing.Size(34, 388);
            this.btquadrado.TabIndex = 0;
            this.btquadrado.Text = "Quadrado";
            this.btquadrado.UseVisualStyleBackColor = true;
            this.btquadrado.Click += new System.EventHandler(this.Btquadrado_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(841, 565);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "...";
            // 
            // btretangulo
            // 
            this.btretangulo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btretangulo.Location = new System.Drawing.Point(83, 12);
            this.btretangulo.Name = "btretangulo";
            this.btretangulo.Size = new System.Drawing.Size(34, 388);
            this.btretangulo.TabIndex = 2;
            this.btretangulo.Text = "Retangulo";
            this.btretangulo.UseVisualStyleBackColor = true;
            this.btretangulo.Click += new System.EventHandler(this.Btretangulo_Click);
            // 
            // bttriangulo
            // 
            this.bttriangulo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttriangulo.Location = new System.Drawing.Point(145, 12);
            this.bttriangulo.Name = "bttriangulo";
            this.bttriangulo.Size = new System.Drawing.Size(34, 388);
            this.bttriangulo.TabIndex = 3;
            this.bttriangulo.Text = "Triangulo";
            this.bttriangulo.UseVisualStyleBackColor = true;
            this.bttriangulo.Click += new System.EventHandler(this.Bttriangulo_Click);
            // 
            // bttrapezio
            // 
            this.bttrapezio.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttrapezio.Location = new System.Drawing.Point(200, 12);
            this.bttrapezio.Name = "bttrapezio";
            this.bttrapezio.Size = new System.Drawing.Size(34, 388);
            this.bttrapezio.TabIndex = 4;
            this.bttrapezio.Text = "Trapezio";
            this.bttrapezio.UseVisualStyleBackColor = true;
            this.bttrapezio.Click += new System.EventHandler(this.Bttrapezio_Click);
            // 
            // txtbma
            // 
            this.txtbma.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbma.Location = new System.Drawing.Point(364, 85);
            this.txtbma.Name = "txtbma";
            this.txtbma.Size = new System.Drawing.Size(148, 50);
            this.txtbma.TabIndex = 5;
            // 
            // txtbme
            // 
            this.txtbme.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbme.Location = new System.Drawing.Point(364, 231);
            this.txtbme.Name = "txtbme";
            this.txtbme.Size = new System.Drawing.Size(148, 50);
            this.txtbme.TabIndex = 6;
            // 
            // txtalt
            // 
            this.txtalt.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalt.Location = new System.Drawing.Point(364, 363);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(148, 50);
            this.txtalt.TabIndex = 7;
            // 
            // ba
            // 
            this.ba.AutoSize = true;
            this.ba.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba.Location = new System.Drawing.Point(357, 23);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(205, 40);
            this.ba.TabIndex = 8;
            this.ba.Text = "Base Maior:";
            // 
            // bm
            // 
            this.bm.AutoSize = true;
            this.bm.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bm.Location = new System.Drawing.Point(357, 166);
            this.bm.Name = "bm";
            this.bm.Size = new System.Drawing.Size(213, 40);
            this.bm.TabIndex = 9;
            this.bm.Text = "Base Menor:";
            // 
            // alt
            // 
            this.alt.AutoSize = true;
            this.alt.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt.Location = new System.Drawing.Point(357, 300);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(128, 40);
            this.alt.TabIndex = 10;
            this.alt.Text = "Altura:";
            // 
            // btfatorial
            // 
            this.btfatorial.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfatorial.Location = new System.Drawing.Point(254, 12);
            this.btfatorial.Name = "btfatorial";
            this.btfatorial.Size = new System.Drawing.Size(34, 388);
            this.btfatorial.TabIndex = 11;
            this.btfatorial.Text = "Fatorial";
            this.btfatorial.UseVisualStyleBackColor = true;
            this.btfatorial.Click += new System.EventHandler(this.Btfatorial_Click);
            // 
            // btfuck
            // 
            this.btfuck.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfuck.Location = new System.Drawing.Point(307, 12);
            this.btfuck.Name = "btfuck";
            this.btfuck.Size = new System.Drawing.Size(34, 388);
            this.btfuck.TabIndex = 12;
            this.btfuck.Text = "Fatorial Invertido";
            this.btfuck.UseVisualStyleBackColor = true;
            this.btfuck.Click += new System.EventHandler(this.Btfuck_Click);
            // 
            // txtfuck
            // 
            this.txtfuck.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfuck.Location = new System.Drawing.Point(307, 350);
            this.txtfuck.Name = "txtfuck";
            this.txtfuck.Size = new System.Drawing.Size(34, 50);
            this.txtfuck.TabIndex = 13;
            this.txtfuck.TextChanged += new System.EventHandler(this.Txtfuck_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 388);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vamu Ver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(797, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 50);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 649);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfuck);
            this.Controls.Add(this.btfuck);
            this.Controls.Add(this.btfatorial);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.bm);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.txtbme);
            this.Controls.Add(this.txtbma);
            this.Controls.Add(this.bttrapezio);
            this.Controls.Add(this.bttriangulo);
            this.Controls.Add(this.btretangulo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btquadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btquadrado;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btretangulo;
        private System.Windows.Forms.Button bttriangulo;
        private System.Windows.Forms.Button bttrapezio;
        private System.Windows.Forms.TextBox txtbma;
        private System.Windows.Forms.TextBox txtbme;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.Label ba;
        private System.Windows.Forms.Label bm;
        private System.Windows.Forms.Label alt;
        private System.Windows.Forms.Button btfatorial;
        private System.Windows.Forms.Button btfuck;
        private System.Windows.Forms.TextBox txtfuck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

