using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma, f, g;
            string[] vet;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                if (x > y)
                {
                    f = y;
                    g = x;
                    x = f;
                    y = g;
                } 

                soma = 0;
                for (int a = x+1; a <= y-1; a++)
                {
                    if ( a % 2 != 0)
                    {
                        soma += a;

                    }
                }
                Console.WriteLine(soma);
               
            }
            Console.ReadLine();           

            

        }
    }
}
