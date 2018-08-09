using System;
using System.Globalization;


namespace Uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3.0);
            Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
