using System;
using System.Globalization;

namespace _1075_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double v1, v2, v3, media, peso;            

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)            {

                string[] vet = Console.ReadLine().Split(' ');
                v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                peso = v1 * 2.0 + v2 * 3.0 + v3 * 5.0;
                media = peso / 10.0;
                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));


            }
            Console.ReadLine();
        }
    }
}
