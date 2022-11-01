using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes
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

        private void Btquadrado_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            lbl.Text = Convert.ToString(geo.Quadrado(10));
        }

        private void Btretangulo_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            lbl.Text = Convert.ToString(geo.Retangulo(10,10));
        }

        private void Bttriangulo_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            lbl.Text = Convert.ToString(geo.Triangulo(10,10));
        }

        private void Bttrapezio_Click(object sender, EventArgs e)
        {
            Geometria geo;
            geo = new Geometria();

            double bma, bme, alt;

            bma = Convert.ToDouble(txtbma.Text);
            bme = Convert.ToDouble(txtbme.Text);
            alt = Convert.ToDouble(txtalt.Text);

            lbl.Text = geo.Trapezio(bma, bme, alt).ToString();

            /* Geometria geo = new Geometria();

            lbl.Text = Convert.ToString(geo.Trapezio(10, 10, 10)); */
        }

        private void Btfatorial_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            lbl.Text = geo.fatorial(15).ToString();
        }

        private void Btfuck_Click(object sender, EventArgs e)
        {
            Geometria geo = new Geometria();

            int fat;

            fat = Convert.ToInt32(txtfuck.Text);

            lbl.Text = geo.fatorialInvertido(fat).ToString();

        }

        private void Txtfuck_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
