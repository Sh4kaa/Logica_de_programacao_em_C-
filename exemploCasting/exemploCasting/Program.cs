using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploCasting
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = (double) a / b; // casting double
            Console.WriteLine(resultado);
            Console.ReadKey();    */

            double a;
            int b;
            a = 5.0;
            b = (int) a; //casting, conversão explicita de um tipo para outro, no caso de double para int
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
