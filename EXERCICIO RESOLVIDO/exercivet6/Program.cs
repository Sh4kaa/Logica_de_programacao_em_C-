using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercivet6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int maior = 0;
            string pessoa="";

            string[] nomes = new string[N];
            int[] idades = new int[N];            
            string[] s;

            

            for ( int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);

                if (idades[i] > maior)
                {
                    maior = idades[i];
                    pessoa = nomes[i];

                }
            }
            Console.WriteLine("Pessoa mais velha: " + pessoa);
            Console.ReadLine();
            

        }
    }
}
