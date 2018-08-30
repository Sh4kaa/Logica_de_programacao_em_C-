using System;
using System.Globalization;


namespace coordenadas1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;            
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0 )
            {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0 )
            {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            } else if ( x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            } else if (x == 0 && y != x)
            {
                Console.WriteLine("Eixo Y");
            } else if (y == 0 && x != 0)
            {
                Console.WriteLine("Eixo X");
            }
            /*se x for igual a zero e y diferente de zero, o ponto está no eixo y
             * e vice versa*/
            Console.ReadLine();
            
        }
    }
}
