using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //*************************** TABUADA ********************************
            
               int i,n1,r;
               string resp = "s";

            while (resp == "s" || resp == "S")
            {
                Console.Clear();
                Console.WriteLine("Insira o número para a tabuada:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*******************************");

                for (i = 0; i <= 10; i++)
                {
                    r = i * n1;
                    Console.WriteLine(n1 + "x" + i + "=" + r);
                }

                Console.WriteLine("Deseja continuar?(s/n)");
                resp = Console.ReadLine();
            }

              */

            // ************************ Calculadora Valor Total de Compra **********************

            double preço, quantidade,subTotal,total=0;
            string nomeProduto,resp="s";

            while (resp == "s" || resp == "S")
            {
                Console.Clear();
                Console.SetCursorPosition(25, 4);
                Console.WriteLine("Insira o nome do produto:");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Insira o preço do produto:");
                preço = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira a quantidade do produto:");
                quantidade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                subTotal = preço * quantidade;
                Console.WriteLine("Produto:" + nomeProduto);
                Console.WriteLine("O subtotal é de: R$" + subTotal);
                total = total + subTotal;
                Console.WriteLine("");

                Console.WriteLine("Deseja continuar?(s/n)");
                resp = Console.ReadLine();
                Console.WriteLine("");

            }

            Console.WriteLine("O valor total a ser pago é de: R$" + total);

            Console.Read();
        }
    }
}
