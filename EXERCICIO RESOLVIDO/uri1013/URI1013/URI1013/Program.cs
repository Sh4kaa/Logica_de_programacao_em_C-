using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorAB, a, b, c;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            //formula maior numero entre 3

             maiorAB = (a + b + Math.Abs(a -b)) / 2;
             maiorAB = (c + maiorAB + Math.Abs(maiorAB - c)) / 2;

            


            Console.WriteLine(maiorAB +" eh o maior");
            Console.ReadLine();

            /* explicação da fórmula

            a b c
            5 6 7

            5 + 6 = 11

            numero absoluto 5 - 6 = -1

            abs = 1

            formula 5 + 6 + 1 = 12 / 2 = 6
            maiorAB = 6
            maiorAB = 7 + 6 + (6 - 7) = 14 / 2 = 7

            maiorab = 7 */


        }
    }
}
