using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar
            // a soma dos elementos acima da diagonal principal.
            int N;
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];
            string[] s;

            //leitura da matriz
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            // soma dos elementos acima da matriz principal
            int soma = 0;
            for (int i = 0; i < N; i++)
            {

                for (int j = i + 1; j < N; j++)
                {

                    soma += mat[i,j];

                }

            }

            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
