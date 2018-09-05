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
            double salario, impostoRenda, diferenca;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 3000)
            {
                impostoRenda = 1000 * 8 / 100;
                diferenca = salario - 3000;
                impostoRenda +=  diferenca * 18 / 100;                
                Console.WriteLine(impostoRenda.ToString("f2", CultureInfo.InvariantCulture));
            } else if ( salario >= 4500)
            {
                impostoRenda = 1500 * 18 / 100;
                diferenca = salario - 4500;
                impostoRenda += diferenca * 28 / 100;
                Console.WriteLine(impostoRenda.ToString("f2", CultureInfo.InvariantCulture));
            } else if (salario > 4500)
            {
                impostoRenda = 1000 * 0.08 + 1500 * 0.18;
                diferenca = salario - 4500;
                impostoRenda += diferenca * 28 / 100;
                Console.WriteLine(impostoRenda.ToString("f2", CultureInfo.InvariantCulture));
            }
            

            

            
        
            Console.ReadLine();
        }
    }
}
