using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculo simples
            int codigoPeca1, codigoPeca2, quantPecas1, quantPecas2;
            double valorPeca1, valorPeca2, valoraPagar;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vet[0]);
            quantPecas1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            // lendo valor da segunda peça
            vet = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vet[0]);
            quantPecas2 = int.Parse(vet[1]);
            valorPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            valoraPagar = valorPeca1 * quantPecas1 + valorPeca2 * quantPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valoraPagar.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
