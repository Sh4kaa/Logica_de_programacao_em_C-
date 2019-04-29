using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            double maiorAlt = 0, menorAlt, mediaAltMulher, aux=0;
            double[] altura = new double[N];
            string[] sexo = new string[N];
            int numHomens;
            string[] dados;

            

            for (int i = 0; i < N; i++)
            {
                dados = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);                
                sexo[i] = dados[1];

               
            }

            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maiorAlt)
                {
                    maiorAlt += altura[i];
                }
            }

            Console.WriteLine(maiorAlt.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
