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
            double delta = b * b - (4 * a * c);

            if (a == 0 || delta < 0) // se o termo "a" for igual a  0 ou o resultado de delta for negativo, naõ é possivel calcular
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("f5", CultureInfo.InvariantCulture));

            }
            Console.ReadLine();


        }
    }
}
