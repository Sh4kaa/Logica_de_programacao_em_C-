using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037_uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            
           

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           if (n1 >= 0.0 && n1 <= 25.0 ) {

                Console.WriteLine("Intervalo [0,25]");

            } else if (n1 > 25.0 && n1 <= 50.0) {
                
                Console.WriteLine("Intervalo (25,50]");

            } else if (n1 > 50.0 && n1 <= 75.0) {

                Console.WriteLine("Intervalo (50,75]");

            } else if (n1 > 75.0 && n1 <= 100.0) {
                
                Console.WriteLine("Intervalo (75,100]");

            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }

            Console.ReadLine();
            

        }
    }
}
