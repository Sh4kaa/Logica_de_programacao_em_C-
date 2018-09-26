using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaograus
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            double F, C;
            Console.WriteLine("Deseja converter Celsius para Fahrenheit? [C > F]= 1");
            Console.WriteLine();          
            Console.WriteLine("Deseja converter Fahrenheit para Celsius? [F > C]= 2");

            Console.Write("Digite uma opção 1 ou 2 > ");

            escolha = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Voce escolheu a opção " + escolha);



            if (escolha == "1")
            {
                Console.Write("Digite o Valor em Celsius: ºC ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = (C * 1.8) + 32;
                Console.WriteLine("A conversão de Celsius para Fahrenheit " + F.ToString("f2", CultureInfo.InvariantCulture));
            }

            if (escolha == "2")
            {
                Console.Write("Digite o Valor em Fahrenheit: ºF ");
                F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                C = (F - 32) / 1.8;
                Console.WriteLine("A conversão de Fahrenheit para Celsius é " + C.ToString("f2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();



        }
    }
}
