using System;
using System.Globalization;

namespace franquia
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor à Pagar R$ " + conta.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
