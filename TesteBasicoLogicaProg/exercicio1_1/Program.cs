using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor
            //unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário
            //de cada peça 2. Calcule e mostre o valor a ser pago.

            int codPeca1, codPeca2, numPeca1, numPeca2;
            double valPeca1, valPeca2, total;
            string[] dados1, dados2;

            dados1 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(dados1[0]);
            numPeca1 = int.Parse(dados1[1]);
            valPeca1 = double.Parse(dados1[2], CultureInfo.InvariantCulture);

            dados2 = Console.ReadLine().Split(' ');

            codPeca2 = int.Parse(dados2[0]);
            numPeca2 = int.Parse(dados2[1]);
            valPeca2 = double.Parse(dados2[2], CultureInfo.InvariantCulture);

            total = numPeca1 * valPeca1 + numPeca2 * valPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
