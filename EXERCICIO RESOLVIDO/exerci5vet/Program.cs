using System;
using System.Globalization;

namespace exerci5vet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;            
            N = int.Parse(Console.ReadLine());
            int aux;
            int soma = 0;
            int cont = 0;
            double media;
            


            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                aux = int.Parse(vet[i]);
                if (aux % 2 == 0)
                {
                    soma += aux;
                    cont++;
                }
            }
            media = (double) soma / cont;
            Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
