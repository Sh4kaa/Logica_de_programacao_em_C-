using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, aux=0;
            string[] vet;
            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                aux += 1;
                if (aux == x)
                {
                    Console.WriteLine();
                    aux = 0;
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ReadLine();
        }
    }
}
