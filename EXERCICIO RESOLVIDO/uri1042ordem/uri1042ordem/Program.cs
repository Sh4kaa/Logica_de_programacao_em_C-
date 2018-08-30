using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1042ordem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int a1, b2, c3, temp;
            string[] vet;
            

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            a1 = a;
            b2 = b;
            c3 = c;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a > c)
            {
                temp = a;
                a = c;
                c = temp;
            }

            if ( b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine();

            Console.WriteLine(a1);
            Console.WriteLine(b2);
            Console.WriteLine(c3);
            Console.ReadLine();





            Console.ReadLine();


        }
    }
}
