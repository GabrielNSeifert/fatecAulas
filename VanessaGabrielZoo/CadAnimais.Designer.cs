namespace VanessaGabrielZoo
{
    partial class CadAnimais
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
            this.label2 = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtanimal = new System.Windows.Forms.TextBox();
            this.txtpaisorigem = new System.Windows.Forms.TextBox();
            this.txtlocalizacao = new System.Windows.Forms.TextBox();
            this.txtcodalimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Animais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(133, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 55);
            this.label2.TabIndex = 23;
            this.label2.Text = "Animal:";
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Black;
            this.btcancelar.Location = new System.Drawing.Point(602, 556);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(259, 92);
            this.btcancelar.TabIndex = 22;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btgravar
            // 
            this.btgravar.BackColor = System.Drawing.Color.Black;
            this.btgravar.Location = new System.Drawing.Point(260, 556);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(259, 92);
            this.btgravar.TabIndex = 21;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = false;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(133, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 55);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cod Alimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(133, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 55);
            this.label3.TabIndex = 24;
            this.label3.Text = "País de Origem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(133, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 55);
            this.label5.TabIndex = 25;
            this.label5.Text = "Localização:";
            // 
            // txtanimal
            // 
            this.txtanimal.Location = new System.Drawing.Point(504, 125);
            this.txtanimal.MaxLength = 15;
            this.txtanimal.Name = "txtanimal";
            this.txtanimal.Size = new System.Drawing.Size(413, 62);
            this.txtanimal.TabIndex = 19;
            // 
            // txtpaisorigem
            // 
            this.txtpaisorigem.Location = new System.Drawing.Point(504, 231);
            this.txtpaisorigem.MaxLength = 15;
            this.txtpaisorigem.Name = "txtpaisorigem";
            this.txtpaisorigem.Size = new System.Drawing.Size(413, 62);
            this.txtpaisorigem.TabIndex = 26;
            // 
            // txtlocalizacao
            // 
            this.txtlocalizacao.Location = new System.Drawing.Point(504, 333);
            this.txtlocalizacao.MaxLength = 15;
            this.txtlocalizacao.Name = "txtlocalizacao";
            this.txtlocalizacao.Size = new System.Drawing.Size(413, 62);
            this.txtlocalizacao.TabIndex = 27;
            // 
            // txtcodalimento
            // 
            this.txtcodalimento.Location = new System.Drawing.Point(504, 442);
            this.txtcodalimento.MaxLength = 15;
            this.txtcodalimento.Name = "txtcodalimento";
            this.txtcodalimento.Size = new System.Drawing.Size(413, 62);
            this.txtcodalimento.TabIndex = 28;
            // 
            // CadAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1059, 679);
            this.Controls.Add(this.txtcodalimento);
            this.Controls.Add(this.txtlocalizacao);
            this.Controls.Add(this.txtpaisorigem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.txtanimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(13);
            this.Name = "CadAnimais";
            this.Text = "CadAnimais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtanimal;
        private System.Windows.Forms.TextBox txtpaisorigem;
        private System.Windows.Forms.TextBox txtlocalizacao;
        private System.Windows.Forms.TextBox txtcodalimento;
    }
}