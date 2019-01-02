using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result=0;
            n = int.Parse(Console.ReadLine());


            if (n % 2 == 0)
            {
                result = n * 2;
                Console.WriteLine(n + "^2 = " + result);
            }

            for (int i = 1; i <= n; i++)
            {
              
                if (i % 2 == 0)
                {
                    
                    result = i * 2;
                    Console.WriteLine(i + "^2 = " + result);
                }

            }
            Console.ReadLine();




           
        }
    }
}
