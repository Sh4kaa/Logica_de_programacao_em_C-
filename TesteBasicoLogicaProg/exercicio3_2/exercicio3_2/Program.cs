using System;

namespace exercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, contDentro=0, contFora=0;
            N = int.Parse(Console.ReadLine());
            int numeros;


            for (int i = 0; i < N; i++)
            {
                numeros = int.Parse(Console.ReadLine());
                if (numeros >= 10 && numeros <= 20)
                {
                    contDentro += 1;
                } else
                {
                    contFora += 1;
                }
            }

            Console.WriteLine(contDentro + " in");
            Console.WriteLine(contFora + " out");
        }
    }
}
