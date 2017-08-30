using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;

            Console.WriteLine("Digite a Quantidade de notas");
            qtd = Convert.ToInt32(Console.ReadLine());

            double[] todasNotas = new double[qtd];
            string maior = "";
            string menor = "";
            double total = 0;
            double media = 0;

            double x = 0;
            for (int i = 0; i < qtd; i++)
            {

                Console.WriteLine("Digite o valor da nota");
                x = Convert.ToDouble(Console.ReadLine());
                todasNotas[i] = x;
                total += x;

            }

            media = total / qtd;
            for (int i = 0; i < qtd; i++)
            {
                if (todasNotas[i] > media)
                    maior += (Convert.ToString(todasNotas[i].ToString()))+",";
                else
                    menor += Convert.ToString(todasNotas[i].ToString())+",";

            }

            Console.WriteLine("Conjunto de notas maiores que a media "+maior);
            Console.WriteLine("Conjunto de notas menores que a media " + menor );

            Console.ReadKey();








        }
    }
}
