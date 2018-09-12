using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1065_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contador=0;

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contador ++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contador++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contador++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contador++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contador++;
            }

            Console.WriteLine(contador + " valores pares");
            Console.ReadLine();
        }
    }
}
