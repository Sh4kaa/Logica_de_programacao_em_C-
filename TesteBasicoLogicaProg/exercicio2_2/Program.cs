using System;
using System.Globalization;

namespace exercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            double x1, x2;
            string[] dados;
            
            // leitura de dados
            dados = Console.ReadLine().Split(' ');
            a = double.Parse(dados[0], CultureInfo.InvariantCulture);
            b = double.Parse(dados[1], CultureInfo.InvariantCulture);
            c = double.Parse(dados[2], CultureInfo.InvariantCulture);

            // fórmula
            double delta = (b * b) - 4 * a * c;

            if ( a <= 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = -b + Math.Sqrt(delta);
                x2 = -b - Math.Sqrt(delta);
                Console.WriteLine("X1 = " + x1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x1.ToString("f5", CultureInfo.InvariantCulture));

            }
            Console.ReadLine();


        }
    }
}
