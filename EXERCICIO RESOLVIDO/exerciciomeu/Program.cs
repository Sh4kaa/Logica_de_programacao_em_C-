using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciomeu
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;            
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N]; 
            string[] s;      
                      
            
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' '); //  a matriz de string "s" recebe dois numeros um na posicao 0 e outro na posicao 1 
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);  // na primeira vez que essa linha executada "mat[i,j]" ("i" e "j" valem 0) recebe o s[j]
                }

            }
            Console.ReadLine();
        }
    }
}
