using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoSomar_Click(object sender, EventArgs e)
        {
            double resultado;

            resultado = Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text);
            resultadoText.Text = Convert.ToString(resultado);
        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            numero1.Text = "";
            numero2.Text = "";
            resultadoText.Text = "";
        }
    }
}
