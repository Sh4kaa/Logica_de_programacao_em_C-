using System;
using System.Globalization;


namespace uri1043triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores reais (A, B e C) e verifique se eles formam
             * ou não um triângulo. Em caso positivo, calcule o perímetro do
             * triângulo e apresente a mensagem: Perimetro = XX.X
             * Em caso negativo, calcule a área do trapézio que tem A e B como base
             * e C como altura, mostrando a mensagem: Area = XX.X */

            double a, b, c, area, perimetro;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);            

            if ((a + b) > c && (a + c) > b && (b + c) > a) // fórmula para saber se é um triângulo
            {
                perimetro = a + b + c; // fórmula perimetro
                Console.WriteLine("Perimetro = " + perimetro.ToString("f1", CultureInfo.InvariantCulture));
            } else
            {
                area = ((a + b) * c) / 2; // fórmula para calcular área de um trapezio
                Console.WriteLine("Area = " + area.ToString("f1", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();        
                    
            
        }
    }
}
