using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_de_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());
            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();

            // adicionando linha de teste

        }
    }
}
