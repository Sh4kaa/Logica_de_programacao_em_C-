using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_temp_C_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char resposta= 's';

            while (resposta == 's')
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("f1", CultureInfo.InvariantCulture));

                Console.Write("Deseja repetir (s/n)?");
                resposta = char.Parse(Console.ReadLine());
            }            
            
            
            Console.ReadLine();

        }
    }
}
