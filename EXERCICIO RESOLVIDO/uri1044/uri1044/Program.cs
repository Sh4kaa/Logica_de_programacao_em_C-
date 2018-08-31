using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar
             * uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
             * indicando se os valores lidos são múltiplos entre si. */

            int a, b;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            
            if ( a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();

          
        }
    }
}
