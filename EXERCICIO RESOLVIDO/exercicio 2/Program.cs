using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            mat = new int[N, M];

            // lendo todos os numero da matriz
            for (int i = 0; i < M; i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s2[j]);
                }
            }
            // Mostrando a diagonal principal
            Console.WriteLine("DIAGONAL PRINCIPAL");
            for (int i = 0; i < M; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();


            // calculando a quantidade de numero negativos
            int soma = 0;
            for (int i = 0; i < M; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        soma++;
                    }

                }

            }
            Console.WriteLine("QUATIDADE DE NUMEROS NEGATIVOS: " + soma);

            Console.ReadLine();

        }
    }
}
