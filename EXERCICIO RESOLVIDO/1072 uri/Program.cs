using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, fora=0, dentro=0;
            

            n = int.Parse(Console.ReadLine());
            x = 0;
            
            


            for (int i = 1; i <= n; i++)
            {

                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
                

            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");


            Console.ReadLine();

        }
    }
}
