using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            if (x % 2 != 0)
            {
                Console.WriteLine(x);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                
            }
            else
            {
                Console.WriteLine(x += 1);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);
                Console.WriteLine(x += 2);

            }         

            

            Console.ReadLine();
        }
    }
}
