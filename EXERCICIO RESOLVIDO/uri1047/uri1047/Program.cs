using System;


namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, horas, minutos;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            horas = horaFinal - horaInicial;
            

            if ( horas == 0)
            {
                horas = 24 + (horaFinal - horaInicial);
            }

            minutos = minutoFinal - minutoInicial;
            
            if (minutos == 0)
            {
                minutos = 60 + (minutoFinal - minutoInicial);
                
            }

            if (horaInicial == horaFinal && minutoInicial == minutoFinal)
            {
                // horas = horas + 24;


                //Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");

                Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTOS");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTOS");
            }
            Console.ReadLine();

            /* segredo é pegar o valor final subtrair pelo inicial,
             * 
             *  */
        }
    }
}
