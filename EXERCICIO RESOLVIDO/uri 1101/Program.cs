﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, a=0, b=0, soma=0;
            string[] vet;

            do
            {
                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
                if (m > n)
                {
                    a = n;
                    b = m;
                   
                }
                for (int i = a; i <= b; i++)
                {
                    soma += i;
                    Console.Write(i + " "+ soma);

                    soma = 0;
                }
            } while (m <= 0 || n <= 0);
            Console.ReadLine();


            
        }
    }
}