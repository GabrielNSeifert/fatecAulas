namespace VanessaGabrielZoo
{
    partial class CadAlimentos
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
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Alimentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(63, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alimento:";
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Black;
            this.btcancelar.Location = new System.Drawing.Point(600, 557);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(259, 92);
            this.btcancelar.TabIndex = 16;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btgravar
            // 
            this.btgravar.BackColor = System.Drawing.Color.Black;
            this.btgravar.Location = new System.Drawing.Point(258, 557);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(259, 92);
            this.btgravar.TabIndex = 15;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = false;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(341, 223);
            this.txtdescricao.MaxLength = 150;
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(653, 297);
            this.txtdescricao.TabIndex = 14;
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(341, 125);
            this.txtalimento.MaxLength = 15;
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(653, 63);
            this.txtalimento.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(63, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição:";
            // 
            // CadAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1059, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "CadAlimentos";
            this.Text = "CadAlimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Label label4;
    }
}