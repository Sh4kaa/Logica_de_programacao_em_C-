using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1064posmedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, soma=0;
            int positivo = 0, contador=0;


            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma =  n + soma;
                contador++;
            }
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma = n + soma;
                contador++;
            }
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma = n + soma;
                contador++;
            }
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma = n + soma;
                contador++;
            }
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma = n + soma;
                contador++;
            }
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n >= 0)
            {
                positivo++;
                soma = n + soma;
                contador++;
            }
            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine((soma / contador).ToString("f1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
