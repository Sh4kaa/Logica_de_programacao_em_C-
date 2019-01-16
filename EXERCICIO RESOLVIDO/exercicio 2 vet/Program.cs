using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2_vet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet;
            int[] numeros = new int[N];
            int[] pares = new int[N];
            int cont = 0;

            vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(vet[i]);
                if ( numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];
                    Console.Write(pares[i]+" ");
                    
                    cont++;
                }
            }
            Console.WriteLine();

            Console.WriteLine(cont);
            Console.ReadLine();

        }
    }
}
