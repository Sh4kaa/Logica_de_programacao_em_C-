using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1, n = 1, a, b, soma = 0;
            string[] vet;

            while (m != 0 && m > 0 && n != 0 && n > 0)
            {
               
                    vet = Console.ReadLine().Split(' ');
                    m = int.Parse(vet[0]);
                    n = int.Parse(vet[1]);

                    if (m > n)
                    {
                        a = n;
                        b = m;
                    }
                    else
                    {
                        a = m;
                        b = n;
                    }

                    for (int z = a; z <= b; z++)
                    {
                        soma += z;
                        Console.Write(z + " ");
                    }
                    Console.Write("Sum=" + soma);
                    soma = 0;
                    Console.WriteLine();
                

            }



            Console.ReadLine();

        }
    }
}
