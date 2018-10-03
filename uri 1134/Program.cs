using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool=0, gasolina=0, diesel=0, voto;
            voto = int.Parse(Console.ReadLine());

            while (voto > 0 && voto <=3 || voto != 4)
            {
                
                if (voto == 1)
                {
                    alcool += 1; 
                } else if (voto == 2)
                {
                    gasolina += 1;
                } else if (voto == 3)
                {
                    diesel += 1;
                }
                voto = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: "+ diesel);


            Console.ReadLine();
            
        }
    }
}
