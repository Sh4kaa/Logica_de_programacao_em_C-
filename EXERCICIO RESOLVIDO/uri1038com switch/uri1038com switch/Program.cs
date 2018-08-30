using System;
using System.Globalization;


namespace uri1038com_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double cachorroQuente = 4.00, xSalada = 4.50, xBacon = 5.00, torradaSimples = 2.00, refrigerente = 1.50;
            double totalPagar;
            int qtdItens, codigo;
            string[] vet;


            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtdItens = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    totalPagar = cachorroQuente * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    totalPagar = xSalada * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    totalPagar = xBacon * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    totalPagar = torradaSimples * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    totalPagar = refrigerente * qtdItens;
                    Console.WriteLine("Total: R$ " + totalPagar.ToString("f2", CultureInfo.InvariantCulture));
                    break;
            }
            Console.ReadLine();

        }
    }
}
