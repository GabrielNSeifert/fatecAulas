using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanessaGabrielZoo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltAlimentos altali = new AltAlimentos();
            altali.Show();
        }

        private void animaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltAnimais altani = new AltAnimais();
            altani.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAnimais cadani = new CadAnimais();
            cadani.Show();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAlimentos cadali = new CadAlimentos();
            cadali.Show();
        }

        private void animaisPorLocalizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConAnimais conani = new ConAnimais();
            conani.Show();
        }

        private void alimentosPorAnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConAlimentos conali = new ConAlimentos();
            conali.Show();
        }

        private void animaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExcAnimais excani = new ExcAnimais();
            excani.Show();
        }
    }
}
