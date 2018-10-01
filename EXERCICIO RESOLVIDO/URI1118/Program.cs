using System;
using System.Globalization;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {

            int novoCalculo;

            double n1, n2, media;

            novoCalculo = 1;

            while (novoCalculo == 1)
            {

                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (n1 < 0.0 || n1 > 10.0)
                {

                    Console.WriteLine("nota invalida");

                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (n2 < 0.0 || n2 > 10.0)
                {

                    Console.WriteLine("nota invalida");

                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (n1 + n2) / 2;

                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());

                while (novoCalculo != 1 && novoCalculo != 2)
                {

                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());

                }

            }
            Console.ReadLine();

        }
    }
}