using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1073_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result = 0;
            
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {

                    result = i * i;
                    Console.WriteLine(i + "^2 = " + result);
                }
            }            
            Console.ReadLine();
        }
    }
}
