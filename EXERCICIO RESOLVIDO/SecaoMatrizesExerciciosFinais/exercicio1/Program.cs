using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[,] mat;
            N = int.Parse(Console.ReadLine());
            mat = new double[N, N];
            string[] s;

            //leitura da matriz de numeros reais
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            // soma de todos os numero positivos da matriz
            double soma2 = 0;
            for (int i = 0; i < N; i++)
            {
                double soma = 0;
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0)
                    {
                        soma = soma + mat[i, j];
                    }
                }
                soma2 += soma;
            }

            // mostrando valor soma dos positivos
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma2.ToString("f1", CultureInfo.InvariantCulture));



            // mostrando uma linha especifica na matriz
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");
                }
            }

            Console.WriteLine();

            // COLUNA ESCOLHIDA
            Console.Write("COLUNA ESCOLHIDA: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 2; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");
                }
            }

            Console.WriteLine();

            //DIAGONALPRINCIPAL
            Console.Write("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA: ");

            //matriz alterada para valores elevados ao quadrado

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    double raiz = 0.0;
                    if (mat[i, j] < 0.0)
                    {
                        raiz = mat[i, j] * mat[i, j];
                        Console.Write(raiz.ToString("f1", CultureInfo.InvariantCulture) + " ");
                    }
                    else
                    {
                        Console.Write(mat[i, j].ToString("f1",CultureInfo.InvariantCulture) + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
