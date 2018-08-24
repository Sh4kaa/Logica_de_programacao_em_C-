using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskara1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if ( a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel de ser calcular");
            } else
            {

            }


        }
    }
}
