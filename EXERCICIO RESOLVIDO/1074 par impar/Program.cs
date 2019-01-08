using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074_par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());

            for (int i=1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0 && x > 0 )
                {
                    Console.WriteLine("EVEN POSITIVE");
                } else if (x % 2 != 0 && x < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                } else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                } else if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else 
                {
                    Console.WriteLine("NULL");
                }                               
                                  
                               
            }
            Console.ReadLine();
        }
    }
}
