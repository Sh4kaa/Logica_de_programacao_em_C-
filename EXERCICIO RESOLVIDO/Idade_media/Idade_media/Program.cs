using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_media
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            string[] vet;
            double media;

            vet = Console.ReadLine().Split(' '); // leitura de dados com "espaço em branco entre as palavras"
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]); // posição do vetor

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double) (idade1 + idade2) / 2.0; // casting double


            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("f1", CultureInfo.InvariantCulture) + " Anos");

            Console.ReadLine();


        }
    }
}
