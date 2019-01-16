using System;
using System.Globalization;

namespace exercicio1_vetor
{
    class Program
    {
        static void Main(string[] args)
        {


            /*1) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
            do vetor(supor não haver empates).Mostrar também a posição do maior elemento. */



            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet;
            double[] aux = new double[N];
            double maior = 0;
            int posicao = 0;


            vet = Console.ReadLine().Split(' '); // lendo vetor na mesma linda
            for (int i = 0; i < N; i++) // indice "for" criado
            {
                aux[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                if (aux[i] > maior)
                {
                    maior = aux[i];
                    posicao = i;
                }

            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

            Console.ReadLine();
        }
    }
}
