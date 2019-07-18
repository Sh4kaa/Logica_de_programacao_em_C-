using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];
            string[] s;

            //leitura dos dados
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //calculo de lucro
            double somaCompra = 0.0;
            double somaVenda = 0.0;
            double lucroTotal;

            for (int i = 0; i < N; i++)
            {
                somaCompra += precoCompra[i];
                somaVenda += precoVenda[i];

            }

            lucroTotal = somaVenda - somaCompra;

            // calculo do percentual de cada produto individualmente
            int contAbaixo10 = 0;
            int contEntre10e20 = 0;
            int acima20 = 0;
            for (int i = 0; i < N; i++)
            {

                double lucro = precoVenda[i] - precoCompra[i];

                double porcentagemDeLucro = lucro / precoCompra[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixo10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10e20++;
                }
                else
                {
                    acima20++;
                }
            }


            //impressão na tela
            Console.WriteLine("Lucro abaixo de 10%: "+ contAbaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: "+ contEntre10e20);
            Console.WriteLine("Lucro acima de 20%: "+ acima20);
            Console.WriteLine();
            Console.WriteLine("Valor total de compra: " + somaCompra.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somaVenda.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro Total: " + lucroTotal.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
