namespace VanessaGabrielZoo
{
    partial class ExcAnimais
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.txtpaisorigem = new System.Windows.Forms.TextBox();
            this.txtanimal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodanimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodalimento = new System.Windows.Forms.TextBox();
            this.txtlocalizacao = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir Animais";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcodalimento);
            this.groupBox2.Controls.Add(this.txtlocalizacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btcancelar);
            this.groupBox2.Controls.Add(this.btgravar);
            this.groupBox2.Controls.Add(this.txtpaisorigem);
            this.groupBox2.Controls.Add(this.txtanimal);
            this.groupBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Location = new System.Drawing.Point(69, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 341);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "País de Origem:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Animal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Black;
            this.btcancelar.Location = new System.Drawing.Point(525, 229);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(233, 94);
            this.btcancelar.TabIndex = 14;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btgravar
            // 
            this.btgravar.BackColor = System.Drawing.Color.Black;
            this.btgravar.Location = new System.Drawing.Point(180, 229);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(233, 94);
            this.btgravar.TabIndex = 13;
            this.btgravar.Text = "Apagar";
            this.btgravar.UseVisualStyleBackColor = false;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // txtpaisorigem
            // 
            this.txtpaisorigem.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaisorigem.Location = new System.Drawing.Point(251, 152);
            this.txtpaisorigem.Name = "txtpaisorigem";
            this.txtpaisorigem.Size = new System.Drawing.Size(196, 44);
            this.txtpaisorigem.TabIndex = 12;
            // 
            // txtanimal
            // 
            this.txtanimal.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanimal.Location = new System.Drawing.Point(251, 71);
            this.txtanimal.Name = "txtanimal";
            this.txtanimal.Size = new System.Drawing.Size(196, 44);
            this.txtanimal.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.txtcodanimal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(69, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.Black;
            this.btpesquisar.Location = new System.Drawing.Point(612, 87);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(233, 94);
            this.btpesquisar.TabIndex = 8;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcodanimal
            // 
            this.txtcodanimal.Location = new System.Drawing.Point(306, 104);
            this.txtcodanimal.Name = "txtcodanimal";
            this.txtcodanimal.Size = new System.Drawing.Size(271, 63);
            this.txtcodanimal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 55);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cod Animal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cod Alimento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Localização:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcodalimento
            // 
            this.txtcodalimento.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodalimento.Location = new System.Drawing.Point(678, 152);
            this.txtcodalimento.Name = "txtcodalimento";
            this.txtcodalimento.Size = new System.Drawing.Size(196, 44);
            this.txtcodalimento.TabIndex = 19;
            // 
            // txtlocalizacao
            // 
            this.txtlocalizacao.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalizacao.Location = new System.Drawing.Point(678, 71);
            this.txtlocalizacao.Name = "txtlocalizacao";
            this.txtlocalizacao.Size = new System.Drawing.Size(196, 44);
            this.txtlocalizacao.TabIndex = 18;
            // 
            // ExcAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1059, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "ExcAnimais";
            this.Text = "ExcAnimais";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodalimento;
        private System.Windows.Forms.TextBox txtlocalizacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.TextBox txtpaisorigem;
        private System.Windows.Forms.TextBox txtanimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodanimal;
        private System.Windows.Forms.Label label6;
    }
}