using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto=0, diferenca;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 4500)
            {
                imposto = 1000 * 8 / 100 + 1500 * 18 / 100;
                diferenca = salario - 4500;
                imposto += diferenca * 28 / 100;
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            } else if ( salario > 3000)
            {
                imposto = 1000 * 8 / 100;
                diferenca = salario - 3000;
                imposto += diferenca * 18 / 100;
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            } else if (salario > 2000)
            {
                diferenca = salario - 2000;
                imposto += diferenca * 8 / 100;
                Console.WriteLine("R$ " + imposto.ToString("f2", CultureInfo.InvariantCulture));

            } else
            {
                Console.WriteLine("Isento");
            }
            
            Console.ReadLine();        
                                
                    
                      
        }
    }
}
