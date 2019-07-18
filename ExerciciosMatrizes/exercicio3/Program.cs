using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N,N];
            string[] s;

            for(int i = 0; i< N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);                  
                   
                }
                
            }

            // maio elemeno de cada linha

            for (int i = 0; i < N; i++)
            {
                int maior = 0;                
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }


            Console.ReadLine();



        }
    }
}
