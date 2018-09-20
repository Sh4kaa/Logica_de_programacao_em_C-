using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma = 0, media;
            int cont = 0;

            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (cont < 2)
            {
                if (nota < 0)
                {
                    Console.WriteLine("nota invalida");
                }
                else if (nota > 0 && nota <= 10)
                {
                    soma = nota + soma;
                    cont++;

                }
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = soma / cont;
            Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
