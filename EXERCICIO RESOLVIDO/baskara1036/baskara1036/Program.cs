﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskara1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;
            String[] vet;

            vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if ( a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("f5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();


        }
    }
}
