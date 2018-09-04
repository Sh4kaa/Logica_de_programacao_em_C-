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

            hora = horaFinal - hInicial;
            

            if ( hora < 0)
            {
                hora += 24;
            }

            minutos = minutoFinal - minutoInicial;
            
            if (minutos < 0)
            {
                minutos += 60;
                hora -= 1;                
            }

            if (minutos == 0 && hora == 0)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTOS");
            }
            Console.ReadLine();

            /* segredo é pegar o valor final subtrair pelo inicial,
             * 
             *  */
        }
    }
}
