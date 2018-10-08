using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, cont = 0;
            double media=0.0;

            while (idade >= 0)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade >= 0)
                {
                    media += idade;
                    cont++;
                }
            }
            
            Console.WriteLine((media / cont).ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
