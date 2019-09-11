using System;


namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int M, N;
             M = int.Parse(Console.ReadLine());
             N = int.Parse(Console.ReadLine());
             int[,] mat = new int[M, N];
             string[] s;
             int[,] vetAux = new int[M, N];


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
             Console.Write("Digite o numero da Fila: ");
             numFila = int.Parse(Console.ReadLine());
             numFila--;

             Console.WriteLine();

             // lendo a fila selecionada e jogando no vetor auxiliar  

             for (int i = numFila; i == numFila; i++)
             {

                 for (int j = 0; j < N; j++)
                 {
                     vetAux[i, j] = mat[i, j];
                 }
             }

             // mostrando a fila da matriz sem alteração

             for (int i = numFila; i == numFila; i++)
             {

                 for (int j = 0; j < N; j++)
                 {
                     if (vetAux[i,j] == 0)
                     {
                         vetAux[i, j] = mat[i, N - 1];
                         Console.Write(vetAux[i, j]);
                     }

                 }

             }*/

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
