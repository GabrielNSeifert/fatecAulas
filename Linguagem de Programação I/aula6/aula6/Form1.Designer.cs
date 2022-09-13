namespace aula6
{
    partial class Meses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meses));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btexibir = new System.Windows.Forms.Button();
            this.lblmes = new System.Windows.Forms.Label();
            this.btexibir2 = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o número:";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtnum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnum.Location = new System.Drawing.Point(426, 87);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(325, 54);
            this.txtnum.TabIndex = 1;
            // 
            // btexibir
            // 
            this.btexibir.BackColor = System.Drawing.Color.Transparent;
            this.btexibir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btexibir.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btexibir.FlatAppearance.BorderSize = 0;
            this.btexibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexibir.ForeColor = System.Drawing.Color.Transparent;
            this.btexibir.Location = new System.Drawing.Point(817, 80);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(276, 71);
            this.btexibir.TabIndex = 2;
            this.btexibir.Text = "Exibir Mês";
            this.btexibir.UseVisualStyleBackColor = false;
            this.btexibir.UseWaitCursor = true;
            this.btexibir.Click += new System.EventHandler(this.Btexibir_Click);
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.BackColor = System.Drawing.Color.Transparent;
            this.lblmes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmes.Location = new System.Drawing.Point(250, 187);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(55, 50);
            this.lblmes.TabIndex = 3;
            this.lblmes.Text = "...";
            // 
            // btexibir2
            // 
            this.btexibir2.BackColor = System.Drawing.Color.Transparent;
            this.btexibir2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btexibir2.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btexibir2.FlatAppearance.BorderSize = 0;
            this.btexibir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexibir2.ForeColor = System.Drawing.Color.Transparent;
            this.btexibir2.Location = new System.Drawing.Point(763, 177);
            this.btexibir2.Name = "btexibir2";
            this.btexibir2.Size = new System.Drawing.Size(395, 71);
            this.btexibir2.TabIndex = 4;
            this.btexibir2.Text = "Exibir Mes (Switch)";
            this.btexibir2.UseVisualStyleBackColor = false;
            this.btexibir2.UseWaitCursor = true;
            this.btexibir2.Click += new System.EventHandler(this.Btexibir2_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.Transparent;
            this.btsair.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btsair.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.btsair.FlatAppearance.BorderSize = 0;
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.ForeColor = System.Drawing.Color.Transparent;
            this.btsair.Location = new System.Drawing.Point(763, 286);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(395, 71);
            this.btsair.TabIndex = 5;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.UseWaitCursor = true;
            this.btsair.Click += new System.EventHandler(this.Btsair_Click);
            // 
            // Meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 639);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btexibir2);
            this.Controls.Add(this.lblmes);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Meses";
            this.Text = "Mês";
            this.Load += new System.EventHandler(this.Meses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.Button btexibir2;
        private System.Windows.Forms.Button btsair;
    }
}

