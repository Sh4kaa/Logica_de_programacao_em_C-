using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5) O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1,
             * sendo cada fila com a mesma quantidade de soldados. Por exemplo, a figura
             * abaixo mostra a organização do pelotão em 3 filas com 8 soldados em cada uma.
             Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila",
             que consiste em dizer o número de uma fila, de modo que os soldados desta fila devem se
             mover para a direita, e o último soldado da direita vai para a posição mais à esquerda.
             Você deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila". 
 
            Entrada: A entrada consiste em um inteiro M representando o número de filas, um inteiro N
            representado a quantidade de soldados por fila, as M filas de soldados (cada soldado é
            representado por um número inteiro), e o número inteiro para o exercício "girar fila".
            Saída: A saída contém a formação do pelotão após a execução do exercício "girar fila". */

            int M, N;
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            int[,] mat = new int[M, N];
            string[] s;


            // leitura da matriz
            for (int i = 0; i < M; i++)
            {

                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);

                }

            }

            Console.WriteLine(); // pula linha

            // leitura do numero da fila
            int numFila;
            int[] gira = new int[N];
            numFila = int.Parse(Console.ReadLine());
            numFila--;

            Console.WriteLine(); //pula linha

            // girando a fila selecionada

            for (int i = 0; i < N; i++)
            {
                if (i == N - 1) { gira[0] = mat[numFila, i]; }
                else { gira[i + 1] = mat[numFila, i]; }
            }

            // devolvendo a fila alterada para matriz
            for (int j = 0; j < N; j++)
            {
                mat[numFila, j] = gira[j];
            }

            // mostra a matriz alterada
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();




        }
    }
}
