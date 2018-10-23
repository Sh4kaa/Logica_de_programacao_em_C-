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
            int x, soma=0, cont=0, sub=0;
            x = 1;

            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                if ( x % 2 == 0)
                {
                    soma += x;
                    while (cont < 4)
                    {               
                                                             
                        cont++;
                        soma += 2;
                    }                       
                                    
                } else
                {
                    sub += 1;
                    while (cont < 5)
                    {

                        sub += 2;
                        cont++;
                        soma += sub;

                    }
                }
                
                Console.WriteLine(soma);

            }
            
            Console.ReadLine();
        }
    }
}
