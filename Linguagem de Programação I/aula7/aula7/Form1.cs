using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula7
{
    public partial class Form1 : Form
    {

        int valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            valor = valor + 1;
            label1.Text = valor.ToString();
        }

        private void BtParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtIniciarParar_Click(object sender, EventArgs e)
        {
            bool timer;

            timer = timer1.Enabled;

            if (timer == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            } 
        } 

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void BtIniciarParar_MouseHover(object sender, EventArgs e)
        {
            btIniciarParar.BackColor = Color.Purple;
        }

        private void BtIniciarParar_MouseLeave(object sender, EventArgs e)
        {
            btIniciarParar.BackColor = Color.Transparent;
        }
    }
}
