using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_RESOLVIDO
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura  ;
            double comprimento  ;           
            double area ;
            double precoMetroQuadrado, preco ;

            largura =Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA=" + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO=" + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            


        }
    }
}
