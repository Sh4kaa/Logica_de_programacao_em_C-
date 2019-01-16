using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3_vet
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3) Faça um programa para ler dois vetores A e B, contendo N elementos cada.
             * Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos
             * elementos correspondentes de A e B. Imprima o vetor C gerado */

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet1;
            string[] vet2;
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            int[] soma = new int[N];

            vet1 = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(vet1[i]);
            }
            

            vet2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(vet2[i]);
            }
            

            for (int i = 0; i < N; i++)
            {
                soma[i] += A[i] + B[i];
                Console.Write(soma[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
