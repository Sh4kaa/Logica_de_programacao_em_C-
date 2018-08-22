using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem, cinquenta, vinte, dez, cinco, dois, um;
            int resto1, resto2, resto3, resto4, resto5, resto6, resto7, N;

            N = int.Parse(Console.ReadLine());

            cem = N / 100;
            resto1 = N % 100;

            cinquenta = resto1 / 50;
            resto2 = resto1 % 50;

            vinte = resto2 / 20;
            resto3 = resto2 % 20;

            dez = resto3 / 10;
            resto4 = resto3 % 10;

            cinco = resto4 / 5;
            resto5 = resto4 % 5;

            dois = resto5 / 2;
            resto6 = resto5 % 2;

            um = resto6 / 1;
            resto7 = resto6 % 1;



            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");

            Console.ReadLine();


        }
    }
}
