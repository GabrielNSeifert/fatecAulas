using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PorFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void VerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void RosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void OutrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cores.ShowDialog();
            this.BackColor = cores.Color;
        }

        private void AmeteloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Yellow;
        }

        private void BrancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
        }

        private void PretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor Forne =new Fornecedor();
            Forne.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            prod.Show();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionário fun = new Funcionário();
            fun.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FonteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fontes.ShowDialog();
            this.Font = Fontes.Font;
        }
    }
}
