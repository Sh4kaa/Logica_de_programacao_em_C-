using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrut_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma=0;
            n = int.Parse(Console.ReadLine());
            
            while (n != 0)
            {
                soma = soma + n;
                n = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
