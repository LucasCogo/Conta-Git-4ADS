using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cod;
            double valortotal = 0;
            double parcelado = 0;
            double avista = 0;
            double x = 0;

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Qual o valor da compra ?");
                x = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("digite o código da transação (v: avista ou p: parcelado");
                cod = Console.ReadLine();
                valortotal += x;

                if (cod == "v")
                    avista += x;
                else
                    parcelado += x / 3;
            }

            Console.WriteLine("Valor avista é:" + avista);
            Console.WriteLine("Valor parcelado é:" + parcelado);
            Console.WriteLine("Valor total de compras é:" + valortotal);
        }
    }
}
