using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, soma = 0;
            int x = 0;


            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));


            Console.WriteLine("novo calculo (1-sim 2-nao)");
            x = int.Parse(Console.ReadLine());


            while (x <= 1 || x > 2)
            {
                
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                
                    
                

            }

            Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));





            Console.ReadLine();





        }
    }
}
