using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string dia;

            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    dia = "segunda";
                    break;
                case 2:
                    dia = "terçca";
                    break;
                case 3:
                    dia = "quarta";
                    break;
                case 4:
                    dia = "quinta";
                    break;
                case 5:
                    dia = "sexta";
                    break;
                case 6:
                    dia = "sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "valor inválido";
                    break;

            }
            Console.WriteLine("O dia da semana é " + dia);
            Console.ReadLine();
        }
    }
}
