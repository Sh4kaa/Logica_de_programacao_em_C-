using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] alunos = new string[N];
            double[] sem1 = new double[N];
            double[] sem2 = new double[N];
            string[] s;
            double media;
            
            


            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                alunos[i] = s[0];
                sem1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                sem2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);                           

            }

            Console.WriteLine("Alunos aprovados:");

            for (int i = 0; i < N; i++)
            {
                media = (sem1[i] + sem2[i]) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(alunos[i]);
                }
            }
            Console.ReadLine();
            
            

        }
    }
}
