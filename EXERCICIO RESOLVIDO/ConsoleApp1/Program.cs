using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior=0, posicao=0;

            for (int i=1; i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());
                if( n >= maior)
                {
                    maior = n;
                    posicao = i;
                    
                }
                
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
