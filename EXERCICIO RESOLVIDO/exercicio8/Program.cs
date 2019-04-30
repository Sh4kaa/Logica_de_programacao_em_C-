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
            //obs para ordenar qual numero é maior.
            // só pegar a variavel que foi gravado o numero
            // e perguntar se é maior que o maior e atribuir a resposta do calculo
            // para a variavel que criou com nome "maior"
            // nesse caso oq foi gravado na variavel altura vai ser atribuido na variavel
            // que colocamos com nome de "maiorAlt"

            Console.WriteLine(maiorAlt.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
