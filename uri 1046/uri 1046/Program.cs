using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , y, tempo;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            tempo = (24 - x) + y;
            if ( tempo > 24)
            {
                tempo = tempo - 24;
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            } else
            {
                Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
            }
            Console.ReadLine();            

           /* segredo é pegar o valor inicial subtrair por 24, no caso 24 menos o horario
            * inicial o resultado soma-se com o horaio final */

                        
        }
    }
}
