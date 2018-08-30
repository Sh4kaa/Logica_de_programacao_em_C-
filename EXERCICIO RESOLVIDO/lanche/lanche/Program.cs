using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            double cachorroQuente=4.00, xSalada=4.50, xBacon=5.00, torradaSimples=2.00, refrigerente=1.50;
            double totalPagar;
            int qtdItens, codigo;
            string[] vet;
            

            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtdItens = int.Parse(vet[1]);

            if (codigo == 1)
            {
               totalPagar = cachorroQuente * qtdItens;
               Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
            } else
            {
                if ( codigo == 2)
                {
                    totalPagar = xSalada * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                } else
                {
                    if ( codigo == 3)
                    {
                        totalPagar = xBacon * qtdItens;
                        Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    } else
                    {
                        if ( codigo == 4)
                        {
                            totalPagar = torradaSimples * qtdItens;
                            Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                        } else
                        {
                            if ( codigo == 5)
                            {
                                totalPagar = refrigerente * qtdItens;
                                Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                            }
                        }
                    }
                    

                }
            }

            Console.ReadLine();



        }
    }
}
