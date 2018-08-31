using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1045_triangulos 
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, temp;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture); 
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if ( b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if ( a != (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            if ( Math.Pow(b, 2) == ( Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ( Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (Math.Pow(a, 2) < (Math.Pow(b,2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && a== c && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            Console.ReadLine();
        }
    }
}
