﻿using System;
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
            
            double nota1, nota2, media;
            do
            {
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                }

            } while (nota1 < 0 || nota1 > 10);


            do
            {
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                }

            } while (nota2 < 0 || nota2 > 10);



            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("f2", CultureInfo.InvariantCulture));             
                                  
            
            Console.ReadLine();
        }
    }
}
