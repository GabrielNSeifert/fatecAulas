namespace Menus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ameteloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cores = new System.Windows.Forms.ColorDialog();
            this.cuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Fontes = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.coresToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.fonteToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.funcionáriosToolStripMenuItem.Text = "F&uncionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClientesToolStripMenuItem,
            this.porFuncionáriosToolStripMenuItem,
            this.porFornecedoresToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.consultaToolStripMenuItem.Text = "C&onsulta";
            // 
            // porClientesToolStripMenuItem
            // 
            this.porClientesToolStripMenuItem.Name = "porClientesToolStripMenuItem";
            this.porClientesToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.porClientesToolStripMenuItem.Text = "Por c&lientes";
            // 
            // porFuncionáriosToolStripMenuItem
            // 
            this.porFuncionáriosToolStripMenuItem.Name = "porFuncionáriosToolStripMenuItem";
            this.porFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.porFuncionáriosToolStripMenuItem.Text = "Por P&rodutos";
            this.porFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.PorFuncionáriosToolStripMenuItem_Click);
            // 
            // porFornecedoresToolStripMenuItem
            // 
            this.porFornecedoresToolStripMenuItem.Name = "porFornecedoresToolStripMenuItem";
            this.porFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.porFornecedoresToolStripMenuItem.Text = "Por &Fornecedores";
            // 
            // coresToolStripMenuItem
            // 
            this.coresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.coresToolStripMenuItem.Name = "coresToolStripMenuItem";
            this.coresToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.coresToolStripMenuItem.Text = "C&ores";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.rosaToolStripMenuItem,
            this.outrasToolStripMenuItem});
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fonteToolStripMenuItem.Text = "F&undo";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuToolStripMenuItem,
            this.cinzaToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.textoToolStripMenuItem.Text = "Te&xto";
            this.textoToolStripMenuItem.Click += new System.EventHandler(this.TextoToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.azulToolStripMenuItem.Text = "&Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.AzulToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.verdeToolStripMenuItem.Text = "&Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.VerdeToolStripMenuItem_Click);
            // 
            // rosaToolStripMenuItem
            // 
            this.rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            this.rosaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.rosaToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.rosaToolStripMenuItem.Text = "&Rosa";
            this.rosaToolStripMenuItem.Click += new System.EventHandler(this.RosaToolStripMenuItem_Click);
            // 
            // outrasToolStripMenuItem
            // 
            this.outrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ameteloToolStripMenuItem,
            this.brancoToolStripMenuItem,
            this.pretoToolStripMenuItem});
            this.outrasToolStripMenuItem.Name = "outrasToolStripMenuItem";
            this.outrasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.outrasToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.outrasToolStripMenuItem.Text = "&Outras";
            this.outrasToolStripMenuItem.Click += new System.EventHandler(this.OutrasToolStripMenuItem_Click);
            // 
            // ameteloToolStripMenuItem
            // 
            this.ameteloToolStripMenuItem.Name = "ameteloToolStripMenuItem";
            this.ameteloToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.ameteloToolStripMenuItem.Text = "&Amerelo";
            this.ameteloToolStripMenuItem.Click += new System.EventHandler(this.AmeteloToolStripMenuItem_Click);
            // 
            // brancoToolStripMenuItem
            // 
            this.brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            this.brancoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.brancoToolStripMenuItem.Text = "&Branco";
            this.brancoToolStripMenuItem.Click += new System.EventHandler(this.BrancoToolStripMenuItem_Click);
            // 
            // pretoToolStripMenuItem
            // 
            this.pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            this.pretoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.pretoToolStripMenuItem.Text = "&Preto";
            this.pretoToolStripMenuItem.Click += new System.EventHandler(this.PretoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // cuToolStripMenuItem
            // 
            this.cuToolStripMenuItem.Name = "cuToolStripMenuItem";
            this.cuToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cuToolStripMenuItem.Text = "Azul";
            // 
            // cinzaToolStripMenuItem
            // 
            this.cinzaToolStripMenuItem.Name = "cinzaToolStripMenuItem";
            this.cinzaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cinzaToolStripMenuItem.Text = "Cinza";
            // 
            // fonteToolStripMenuItem1
            // 
            this.fonteToolStripMenuItem1.Name = "fonteToolStripMenuItem1";
            this.fonteToolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.fonteToolStripMenuItem1.Text = "Fontes";
            this.fonteToolStripMenuItem1.Click += new System.EventHandler(this.FonteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ameteloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog cores;
        private System.Windows.Forms.ToolStripMenuItem cuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem1;
        private System.Windows.Forms.FontDialog Fontes;
    }
}

