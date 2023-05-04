namespace VanessaGabrielZoo
{
    partial class AltAlimentos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodalimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Alimentos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.txtcodalimento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(88, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.Black;
            this.btpesquisar.Location = new System.Drawing.Point(611, 107);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(233, 63);
            this.btpesquisar.TabIndex = 8;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcodalimento
            // 
            this.txtcodalimento.Location = new System.Drawing.Point(317, 107);
            this.txtcodalimento.Name = "txtcodalimento";
            this.txtcodalimento.Size = new System.Drawing.Size(271, 63);
            this.txtcodalimento.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 55);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cod Alimento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btcancelar);
            this.groupBox2.Controls.Add(this.btgravar);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.txtalimento);
            this.groupBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Location = new System.Drawing.Point(88, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 341);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descrição:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 55);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome do Alimento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Black;
            this.btcancelar.Location = new System.Drawing.Point(494, 241);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(210, 63);
            this.btcancelar.TabIndex = 14;
            this.btcancelar.Text = "Cancelar:";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btgravar
            // 
            this.btgravar.BackColor = System.Drawing.Color.Black;
            this.btgravar.Location = new System.Drawing.Point(187, 241);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(210, 63);
            this.btgravar.TabIndex = 13;
            this.btgravar.Text = "Gravar:";
            this.btgravar.UseVisualStyleBackColor = false;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(465, 151);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(362, 63);
            this.txtdescricao.TabIndex = 12;
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(465, 65);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(362, 63);
            this.txtalimento.TabIndex = 10;
            // 
            // AltAlimentos
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
            this.Name = "AltAlimentos";
            this.Text = "AltAlimentos";
            this.Load += new System.EventHandler(this.AltAlimentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodalimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtalimento;
    }
}