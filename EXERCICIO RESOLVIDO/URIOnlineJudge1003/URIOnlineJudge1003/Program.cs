using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URIOnlineJudge1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;
            A = Int32.Parse(Console.ReadLine());
            B = Int32.Parse(Console.ReadLine());// poderia ser usado também "int.Parse" na conversão de String pra inteiro
            SOMA = A + B;
            Console.WriteLine("SOMA = "+SOMA);            

        }
    }
}
