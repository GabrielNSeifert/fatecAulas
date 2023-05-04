namespace VanessaGabrielZoo
{
    partial class ConAlimentos
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
            this.txtanimal = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Alimentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animal:";
            // 
            // txtanimal
            // 
            this.txtanimal.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanimal.Location = new System.Drawing.Point(274, 116);
            this.txtanimal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtanimal.Name = "txtanimal";
            this.txtanimal.Size = new System.Drawing.Size(386, 63);
            this.txtanimal.TabIndex = 2;
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.Black;
            this.btpesquisar.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Location = new System.Drawing.Point(691, 116);
            this.btpesquisar.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(250, 63);
            this.btpesquisar.TabIndex = 3;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // grade
            // 
            this.grade.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade.Location = new System.Drawing.Point(92, 219);
            this.grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(849, 406);
            this.grade.TabIndex = 4;
            // 
            // ConAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1021, 679);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtanimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ConAlimentos";
            this.Text = "ConAlimentos";
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtanimal;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.DataGridView grade;
    }
}