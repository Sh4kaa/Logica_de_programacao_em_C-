using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testemaiornumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Digite um numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("MAior numero é: " + a);
            } else
            {
                if (b > c)
                {
                    Console.WriteLine("MAior numero é: " + b);
                } else
                {
                    Console.WriteLine("MAior numero é: " + c);
                }
                Console.ReadLine();
            }
        }
    }
}
