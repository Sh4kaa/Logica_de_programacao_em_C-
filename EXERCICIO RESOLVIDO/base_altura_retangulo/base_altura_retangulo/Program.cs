using System;
using System.Globalization;


namespace base_altura_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = 3.14159 * raio * raio; // PI vezes raio ao quadrado para calcular area
            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
