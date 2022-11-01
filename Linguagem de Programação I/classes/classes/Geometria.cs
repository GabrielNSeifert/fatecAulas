using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Geometria
    {
        public double Quadrado(double lado)
        {
            double area;

            area = lado * lado;

            return area;
        }


        public double Retangulo(double bas, double alt)
        {
            double area;

            area = bas * alt;

            return area;
        }

        public double Triangulo(double bas, double alt)
        {
            return bas * alt / 2;
        }

        public double Trapezio(double bas, double basM, double alt)
        {
            return (bas + basM) / 2 * alt;
        }

        public int fatorial(int num)
        {

            int i = 0, fat = 1;

            for(i = 1; i<=num; i++)
            {
                fat = fat * i;
            }

            return fat;

        }

        public int fatorialInvertido(int num)
        {

            int i = 0, fat = 0;

            for (i = 0; i <= num; i++)
            {
                fat = fat + i;
            }

            return fat;
        }

    }/*         Class Geometria            */
}
