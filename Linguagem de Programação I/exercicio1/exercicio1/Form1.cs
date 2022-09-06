using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double densidade1, velocidade1, diametro1, viscosidade1;

            densidade1 = Convert.ToDouble(densidade.Text);
            velocidade1 = Convert.ToDouble(velocidade.Text);
            diametro1 = Convert.ToDouble(diametro.Text);
            viscosidade1 = Convert.ToDouble(viscosidade.Text);
            nr.Text = Convert.ToString((densidade1 * velocidade1 * diametro1) / viscosidade1);

            if (Convert.ToDouble(nr.Text) >= 2000)
            {
                imagem.Load(Application.StartupPath + "\\Turbilhonado.png");
            } else
            {
                imagem.Load(Application.StartupPath + "\\Laminado.png");
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            densidade.Text = "";
            velocidade.Text = "";
            diametro.Text = "";
            viscosidade.Text = "";
            nr.Text = "";
            imagem.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
