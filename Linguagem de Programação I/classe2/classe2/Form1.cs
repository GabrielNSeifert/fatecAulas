using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe2
{
    public partial class Form1 : Form
    {

        Tempo t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            t = new Tempo();

            label1.Text = t.ImprimirTempo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            t = new Tempo(13, 115, 700);
            //t.minuto = 500;
            label2.Text = t.ImprimirTempo();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            t = new Tempo(12);

            label3.Text = t.ImprimirTempo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
