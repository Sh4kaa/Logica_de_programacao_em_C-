using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_base_perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * b + 2 * a; // duas vezes base + duas vezes altura que o mesmo que somar todos os lados
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0)); // fórmula raiz quadrada de (base²+altura²)
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

            /* exemplo da fórmula
             * d² = 8² + 8²    =  duas vezes base + duas vezes altura que o mesmo que somar todos os lados
             * d² = 64 + 64
             * d² = 128
             * d = √128
             * 
             * d = 11,31 cm, aproximadamente
             * 
             * */

        }
    }
}
