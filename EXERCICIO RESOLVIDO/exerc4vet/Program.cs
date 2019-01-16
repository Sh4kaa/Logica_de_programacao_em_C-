using System;
using System.Globalization;

namespace exerc4vet
{
    class Program
    {
        static void Main(string[] args)
        {
          /*4) Fazer um programa para ler um vetor de N números reais.
           * Em seguida, mostrar na tela a média aritmética de todos
           * elementos. Depois mostrar todos os elementos do vetor que
           * estejam abaixo da média. */

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet;
            double[] num = new double[N];
            double media = 0.0;
            double soma = 0;
            int cont = 0;
            double[] aux = new double[N];

            vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                num[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                cont++;
                soma += num[i]; 
                
            }
            media = soma / cont;

            Console.WriteLine(media.ToString("f3", CultureInfo.InvariantCulture));
            for (int i = 0; i < N; i++)
            {
                aux[i] = num[i];
                if ( aux[i] < media)
                {
                    Console.WriteLine(aux[i].ToString("f1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();





        }
    }
}
