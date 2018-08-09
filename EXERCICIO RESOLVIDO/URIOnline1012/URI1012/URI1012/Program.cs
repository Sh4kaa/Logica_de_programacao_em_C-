using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            double A, B, C, pi = 3.14159, areaTriangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet;
            
            // entrada de dados
            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // fórmulas
            areaTriangulo = A * C / 2; // BASE VEZES ALTURA / 2
            circulo = pi * C * C; // pi VEZES O RAIO AO QUADRADO
            trapezio = (A + B) / 2 * C; // base maior + base menor / 2  vezes a altura
            quadrado = B * B; // lado vezes lado
            retangulo = A * B; // base vezes a altura

            //saida de dados
            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
