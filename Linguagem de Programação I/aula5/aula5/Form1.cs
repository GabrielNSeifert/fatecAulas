using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotaoCalcular_Click(object sender, EventArgs e)
        {
            int idade;

            idade = Convert.ToInt32(txtatual.Text) - Convert.ToInt32(txtnasc.Text);
            txtidade.Text = Convert.ToString(idade);

            if (Convert.ToInt32(txtidade.Text) >= 18)
            {
                picimagem.Load(Application.StartupPath + "\\pode.jpg");
                lbMensagem.Text = "Permitido dirigir!";
            }
            else
            {
                picimagem.Load("C:\\Users\\lab5.LABTEC\\Documents\\naopode.jpg");
                lbMensagem.Text = "Não é permitido dirigir!";
            }
        }

        private void LbAno_Click(object sender, EventArgs e)
        {

        }

        private void LbAnoNasc_Click(object sender, EventArgs e)
        {

        }

        private void LbIdade_Click(object sender, EventArgs e)
        {

        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            txtatual.Text = "";
            txtidade.Text = "";
            txtnasc.Text = "";
            lbMensagem.Text = "...";
            picimagem.Image = null;

        }

        private void Txtidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtnasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtatual_TextChanged(object sender, EventArgs e)
        {

        }

        private void Picimagem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
