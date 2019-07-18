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
            double mediaAltMulher, soma=0.0;
            double[] altura = new double[N];
            string[] sexo = new string[N];
            int cont=0;
            string[] dados;
            int quantH = 0;


            

            for (int i = 0; i < N; i++)
            {
                dados = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);                
                sexo[i] = dados[1];
                if (sexo[i] == "F")
                {
                    cont++;
                    soma += altura[i];
                }
                if ( sexo[i] == "M")
                {
                    quantH++; 
                }
               
            }

            // comparação menor altura
            int menorAlt = 0;
            double menor=0.0;

            for (int i = 0; i < N; i++)
            {
                if (altura[i] < altura[menorAlt])
                {
                    menorAlt = i;
                    menor = altura[i];
                }

            }
            Console.WriteLine("Menor Altura = " + menor.ToString("f2", CultureInfo.InvariantCulture));


            // comparação maior altura

            double maiorAlt = 0;

            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maiorAlt)
                {
                    maiorAlt = altura[i];
                }

               
            }
            mediaAltMulher = soma / cont;

            Console.WriteLine("Maior Altura = " + maiorAlt.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres " + mediaAltMulher.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens " + quantH);

            
            //obs para ordenar qual numero é maior.
            // só pegar a variavel que foi gravado o numero
            // e perguntar se é maior que o maior e atribuir a resposta do calculo
            // para a variavel que criou com nome "maior"
            // nesse caso oq foi gravado na variavel altura vai ser atribuido na variavel
            // que colocamos com nome de "maiorAlt"

            
            
            Console.ReadLine();



        }
    }
}
