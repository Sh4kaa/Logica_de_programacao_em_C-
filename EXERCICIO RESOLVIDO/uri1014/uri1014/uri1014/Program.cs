using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consumo;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = (double) x / y;




            Console.WriteLine(consumo.ToString("f3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();


        }
    }
}
