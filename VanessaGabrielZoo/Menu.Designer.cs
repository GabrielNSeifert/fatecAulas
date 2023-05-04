namespace VanessaGabrielZoo
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisPorLocalizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosPorAnimaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 63);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentosToolStripMenuItem,
            this.animaisToolStripMenuItem1});
            this.alterarToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(169, 59);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alimentosToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(302, 60);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            this.alimentosToolStripMenuItem.Click += new System.EventHandler(this.alimentosToolStripMenuItem_Click);
            // 
            // animaisToolStripMenuItem1
            // 
            this.animaisToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animaisToolStripMenuItem1.ForeColor = System.Drawing.Color.LimeGreen;
            this.animaisToolStripMenuItem1.Name = "animaisToolStripMenuItem1";
            this.animaisToolStripMenuItem1.Size = new System.Drawing.Size(302, 60);
            this.animaisToolStripMenuItem1.Text = "Animais";
            this.animaisToolStripMenuItem1.Click += new System.EventHandler(this.animaisToolStripMenuItem1_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem,
            this.alimentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(205, 59);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animaisToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(283, 60);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.animaisToolStripMenuItem_Click);
            // 
            // alimentoToolStripMenuItem
            // 
            this.alimentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alimentoToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.alimentoToolStripMenuItem.Name = "alimentoToolStripMenuItem";
            this.alimentoToolStripMenuItem.Size = new System.Drawing.Size(283, 60);
            this.alimentoToolStripMenuItem.Text = "Alimento";
            this.alimentoToolStripMenuItem.Click += new System.EventHandler(this.alimentoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisPorLocalizaçãoToolStripMenuItem,
            this.alimentosPorAnimaisToolStripMenuItem});
            this.consultarToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(219, 59);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // animaisPorLocalizaçãoToolStripMenuItem
            // 
            this.animaisPorLocalizaçãoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animaisPorLocalizaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.animaisPorLocalizaçãoToolStripMenuItem.Name = "animaisPorLocalizaçãoToolStripMenuItem";
            this.animaisPorLocalizaçãoToolStripMenuItem.Size = new System.Drawing.Size(579, 60);
            this.animaisPorLocalizaçãoToolStripMenuItem.Text = "Animais por Localização";
            this.animaisPorLocalizaçãoToolStripMenuItem.Click += new System.EventHandler(this.animaisPorLocalizaçãoToolStripMenuItem_Click);
            // 
            // alimentosPorAnimaisToolStripMenuItem
            // 
            this.alimentosPorAnimaisToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alimentosPorAnimaisToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.alimentosPorAnimaisToolStripMenuItem.Name = "alimentosPorAnimaisToolStripMenuItem";
            this.alimentosPorAnimaisToolStripMenuItem.Size = new System.Drawing.Size(579, 60);
            this.alimentosPorAnimaisToolStripMenuItem.Text = "Alimentos por Animais";
            this.alimentosPorAnimaisToolStripMenuItem.Click += new System.EventHandler(this.alimentosPorAnimaisToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem2});
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(174, 59);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // animaisToolStripMenuItem2
            // 
            this.animaisToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animaisToolStripMenuItem2.ForeColor = System.Drawing.Color.LimeGreen;
            this.animaisToolStripMenuItem2.Name = "animaisToolStripMenuItem2";
            this.animaisToolStripMenuItem2.Size = new System.Drawing.Size(266, 60);
            this.animaisToolStripMenuItem2.Text = "Animais";
            this.animaisToolStripMenuItem2.Click += new System.EventHandler(this.animaisToolStripMenuItem2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1059, 679);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "Menu";
            this.Text = "Menuu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisPorLocalizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosPorAnimaisToolStripMenuItem;
    }
}