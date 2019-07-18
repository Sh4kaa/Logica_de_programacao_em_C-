using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] leit;
            leit = Console.ReadLine().Split(' ');
            M = int.Parse(leit[0]);
            N = int.Parse(leit[1]);

            int[,] mat = new int[M, N]; //1
            int[,] mat2 = new int[M, N]; //2
            int[,] mat3 = new int[M, N]; //3

            // primeira matriz
            for (int i =0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j< N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Segunda Matriz");

            // segunda matriz
            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat2[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Terceira Matriz com a soma de cada elemento das anteriores");

            //terceira matriz
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat3[i, j] = mat2[i, j] + mat[i, j];
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }




            Console.ReadLine();




        }
    }
}
