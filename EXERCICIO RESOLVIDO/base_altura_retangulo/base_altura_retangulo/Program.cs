using System;



namespace base_altura_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            raio = double.Parse(Console.ReadLine());
            area = 3.14159 * raio * raio;
            Console.WriteLine("A=" + area.ToString("F4"));

            // forma cxorreta que Judge online aceita
        }
    }
}