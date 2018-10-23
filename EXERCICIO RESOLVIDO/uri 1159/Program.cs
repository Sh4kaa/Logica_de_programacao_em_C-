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
            int x, soma = 0, troca, cont=0;


            x = int.Parse(Console.ReadLine());
            while(x != 0)
            {
                if(x %  2 == 0)
                {
                    troca = x; 
                    while(cont < 5)
                    {
                        soma += troca;
                        troca = troca + 2;
                        cont++;

                    }

                    Console.WriteLine(soma);

                }
                else
                {
                    x += +1;
                    troca = x;

                    while (cont < 5)
                    {
                        soma += troca;
                        troca = troca + 2;
                        cont++;

                    }

                    Console.WriteLine(soma);
                }

                x = int.Parse(Console.ReadLine());
                soma = 0;
                troca = 0;
                cont = 0;
            }
            Console.ReadLine();

        }
    }
}
