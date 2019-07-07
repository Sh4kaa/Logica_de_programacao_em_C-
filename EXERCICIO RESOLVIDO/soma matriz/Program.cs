using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;
            string[] s = Console.ReadLine().Split(' '); // escrevendo em uma linha
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            mat = new int[M, N]; // estanciando a matriz

            // leitura da matriz de linhas e colunas
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];

            // varrendo a matriz


            for (int i = 0; i < M; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma += mat[i, j];
                }
                vet[i] = soma;
            }

            // varrendo  vetor para mostrar o valor da linha

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadLine();
        }
    }
}
