using System;
using System.Globalization;

namespace exercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = pi * raio * raio;

            Console.WriteLine(area.ToString("f4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
