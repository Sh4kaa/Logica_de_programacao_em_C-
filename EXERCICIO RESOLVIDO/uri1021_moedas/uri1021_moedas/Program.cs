using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1021_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem, cinquenta, vinte, dez, cinco, dois;
            int resto1, resto2, resto3, resto4, resto5, resto6;            
            int m1, m050, m025, m010, m05, m01, N1;
            double  N;
           
            

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N1 = (int) N * 100;
            
            

            
            //conversao de notas
            cem =  (int) N / 100;
            resto1 = (int) N % 100;

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


            resto6 =  73 * 100 ;
                                 
            
            //conversao moedas
            m1 =   resto6 / 100;
            resto6 = resto6 % 100;

            m050 = resto6 / 50;
            resto6 = resto6 % 50;

            m025 = resto6 / 25;
            resto6 = resto6 % 25;

            m010 = resto6 / 10;
            resto6 = resto6 % 10;

            m05 = resto6 / 5;
            resto6 = resto6 % 5;

            m01 = resto6 / 1;
            resto6 = resto6 % 1;




            Console.WriteLine("NOTAS:");
            Console.WriteLine(cem + " nota(s) de R$ 100.00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine(vinte + " nota(s) de R$ 20.00");
            Console.WriteLine(dez + " nota(s) de R$ 10.00");
            Console.WriteLine(cinco + " nota(s) de R$ 5.00");
            Console.WriteLine(dois + " nota(s) de R$ 2.00");

            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m050 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(m01 + " moeda(s) de R$ 0.01");


            Console.ReadLine();


        }
    }
}
