using System;


namespace mediaa2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir,
             * calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota
             * C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.*/

            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

            Console.WriteLine("MEDIA = "+ MEDIA.ToString("f1"));

            Console.ReadLine();

            
        }
    }
}
