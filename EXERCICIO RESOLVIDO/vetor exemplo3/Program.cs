using System;
using System.Globalization;

namespace vetor_exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] a; // declarar o vetor
            double soma = 0.0;

            n = int.Parse(Console.ReadLine()); // leitura da variável
            a = new double[n]; // depois alocar ele na memória

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                soma += a[i];
            }

            double media = soma / n;

            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
