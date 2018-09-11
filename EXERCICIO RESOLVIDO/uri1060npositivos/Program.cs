using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1060npositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int positivo = 0;

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if ( n >= 0)
            {
                positivo++;
            }

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
            }

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
            }

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
            }

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
            }

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
            }

            Console.WriteLine(positivo + " valores positivos");
            Console.ReadLine();

        }
    }
}
