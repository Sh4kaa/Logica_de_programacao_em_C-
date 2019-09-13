using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod;
            int quantidade;
            string[] dados;
            double valor, total;


            dados = Console.ReadLine().Split(' ');
            cod = int.Parse(dados[0]);
            quantidade = int.Parse(dados[1]);

            if (cod == 1)
            {
                valor = 4.00;
            }
            else if (cod == 2)
            {
                valor = 4.50;
            }
            else if (cod == 3)
            {
                valor = 5.00;
            }
            else if (cod == 4)
            {
                valor = 2.00;
            }
            else
            {
                cod = 5;
                valor = 1.50;
            }
            total = valor * quantidade;

            Console.WriteLine("Total: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
