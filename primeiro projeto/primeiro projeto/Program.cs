using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais!");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); // configuração de casas decimais com 2 casas
            Console.WriteLine(x.ToString("F4")); // // configuração de casas decimais com 4 casas
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // configuração regional para trocar a virgula e usar um ponto
            Console.WriteLine();
            
            // exemplos de concatenação
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();
        }
    }
}
