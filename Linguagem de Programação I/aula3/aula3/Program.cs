using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double velocidade = 50, dist = 100, tempo = 2;

            Console.WriteLine("A velocidade é de: " + velocidade + " km/h\n" + "Para a distancia de: " + dist + " m\nE o tempo de: " + tempo + " h\n\n");
            Console.Write("A velocidade é de: {0} km/h \nPara a distancia de: {1} m\nLeva o tempo de: {2} h\n\n", velocidade, dist, tempo);
            Console.Write("Para a distancia de {0} e o tempo de {1} h, a velocidade é de {2} km/h \n\n\n", dist, tempo, velocidade);

            Console.Write("Informe a Distancia (Km):");
            dist = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o Tempo (Horas):");
            tempo = Convert.ToDouble(Console.ReadLine());

            velocidade = dist / tempo;

            Console.Write("A velocidade é de: {0} Km/h",velocidade);*/




            // ************************************************ CALCULADORA REYNOLDS *******************************************************

            /* double nr, velocidade, densidade, diametro, viscosidade;

             Console.WriteLine("***************Calculadora Reynolds******************\n");

             Console.WriteLine("Digite a velocidade:");
             velocidade = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Digite a densidade:");
             densidade = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Digite o diametro:");
             diametro = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Digite a viscosidade:");
             viscosidade = Convert.ToDouble(Console.ReadLine());

             nr = (velocidade * densidade * diametro) / viscosidade;

             Console.Write("O valor é {0}\n\n",nr);

             if (nr >= 2000)
             {
                 Console.WriteLine("Turbilhonado");
             }
             else
             {
                 Console.WriteLine("Laminado");
             } */

            //**************************** Calculo de Área de Trapézio ***********************************

            //area = (baseMaior * baseMenor)/2 * altura

            double area, baseMaior, baseMenor, altura;

            Console.WriteLine("************************Calculo de Área de Trapézio*************************");

            Console.WriteLine("Digite o valor da Base Maior:");
            baseMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da Base Menor:");
            baseMenor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da Altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            area = (baseMaior + baseMenor) / 2 * altura;

            Console.WriteLine("O valor da Área é de: {0}", area);

            Console.Read();
        }
    }
}
