using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6
{
    public partial class Meses : Form
    {
        public Meses()
        {
            InitializeComponent();
        }

        private void Btexibir_Click(object sender, EventArgs e)
        {
            int num;

            num = Convert.ToInt16(txtnum.Text);

            if (num == 1)
            {
                lblmes.Text = "Janeiro";

            } 
            else if (num == 2)
            {
                lblmes.Text = "Fevereiro";
            }
            else if (num == 3)
            {
                lblmes.Text = "Março";
            }
            else if (num == 4)
            {
                lblmes.Text = "Abril";
            }
            else if (num == 5)
            {
                lblmes.Text = "Maio";
            }
            else if (num == 6)
            {
                lblmes.Text = "Junho";
            }
            else if(num == 7)
            {
                lblmes.Text = "Julho";
            }
            else if (num == 8)
            {
                lblmes.Text = "Agosto";
            }
            else if (num == 9)
            {
                lblmes.Text = "Setembro";
            }
            else if (num == 10)
            {
                lblmes.Text = "Outubro";
            }
            else if (num == 11)
            {
                lblmes.Text = "Novembro";
            }
            else if (num == 12)
            {
                lblmes.Text = "Dezembro";
            }
            else
            {
                lblmes.Text = "Esse mês não existe.";
            }
        }

        private void Btexibir2_Click(object sender, EventArgs e)
        {

            int num;
            num = Convert.ToInt16(txtnum.Text);

            switch (num)
            {
                case 1:
                lblmes.Text = "Janeiro";
                    break;
                case 2:
                    lblmes.Text = "Fevereiro";
                    break;
                case 3:
                    lblmes.Text = "Março";
                    break;
                case 4:
                    lblmes.Text = "Abril";
                    break;
                case 5:
                    lblmes.Text = "Maio";
                    break;
                case 6:
                    lblmes.Text = "Junho";
                    break;
                case 7:
                    lblmes.Text = "Julho";
                    break;
                case 8:
                    lblmes.Text = "Agosto";
                    break;
                case 9:
                    lblmes.Text = "Setembro";
                    break;
                case 10:
                    lblmes.Text = "Outubro";
                    break;
                case 11:
                    lblmes.Text = "Novembro";
                    break;
                case 12:
                    lblmes.Text = "Dezembro";
                    break;
                default:
                    lblmes.Text = "Esse mês não existe!";
                    break;
            }
        }

        private void Meses_Load(object sender, EventArgs e)
        {

        }

        private void Btsair_Click(object sender, EventArgs e)
        {

            DialogResult resp;

            MessageBox.Show("Obrigado por usar nossos softwares!", "Tmj Familia!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);

            resp = MessageBox.Show("Deseja fechar o programa?", "Mensagem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resp == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
