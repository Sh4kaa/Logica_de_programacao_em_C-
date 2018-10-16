using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma = 0, troca;

            x = int.Parse(Console.ReadLine());
            while(x != 0)
            {
                if(x %  2 == 0)
                {
                    troca = x; 
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    Console.WriteLine(soma);

                }
                else
                {
                    x = x + 1; 
                    troca = x;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    troca = troca + 2;
                    soma += troca;
                    Console.WriteLine(soma);
                }
                x = int.Parse(Console.ReadLine());
                soma = 0;
                troca = 0;
            }
            Console.ReadLine();

        }
    }
}
