using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicial, minutoInicial, horaFinal, minutoFinal, tempo, hora, minutos;
            string[] vet;
            vet = Console.ReadLine().Split(' ');
            hInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            hora = (24 - hInicial) + horaFinal;
            minutos = (60 - minutoInicial) + minutoFinal;
            if (hora > 24 )
            {
                hora = hora - 24;
                minutos = minutos - 60;
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTOS" );
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTOS");
            }
            Console.ReadLine();

            /* segredo é pegar o valor inicial subtrair por 24, no caso 24 menos o horario
             * inicial o resultado soma-se com o horaio final */
        }
    }
}
