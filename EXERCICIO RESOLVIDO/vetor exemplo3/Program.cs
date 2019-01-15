using System;
using System.Globalization;

namespace vetor_exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variáveis
            int n;
            double[] a; // declarar o vetor
            double soma = 0.0;

            n = int.Parse(Console.ReadLine()); // leitura da variável
            a = new double[n]; // depois alocar ele na memória

            string[] s = Console.ReadLine().Split(' ');

            // "for" para leitura dos dados ou entrada de dados
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            // "for" para escrever na tela
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //"for" para calcular a soma dos dados
            for (int i = 0; i < n; i++)
            {
                soma += a[i];
            }

            double media = soma / n; // declaração variável média com a atribuição.

            // saída de dados
            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

            // considerações
            /* Esse código poderia ser resumido em apenas um "for", porém por
             * questões acadêmicas e de bons modos, fica mais claro
             * entender o código dessa forma, pois fica menos embaralhado */

        }
    }
}
