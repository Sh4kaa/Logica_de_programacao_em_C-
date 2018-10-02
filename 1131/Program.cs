using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] vet;
            int inter = 0, gremio = 0, novoGrenal, grenais = 0, empates = 0, inter2=0, gremio2=0;

            novoGrenal = 1;
            while (novoGrenal == 1)
            {
                grenais++;
                vet = Console.ReadLine().Split(' ');

                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);               
                                    
                
                if ( inter > gremio)
                {
                    inter2++;
                } else if (inter < gremio)
                {
                    gremio2++;
                } else
                {
                    empates = empates + 1;
                }
                

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + inter2);
            Console.WriteLine("Gremio:" + gremio2);      
            Console.WriteLine("Empates:" + empates);

            if (gremio2 > inter2)
            {
                Console.WriteLine("Gremio venceu mais");
            } else if (gremio2 < inter2)
            {
                Console.WriteLine("Inter venceu mais");
            } else 
            {
                Console.WriteLine("Nao houve vencedor");
            }
            
            Console.ReadLine();          
            

        }
    }
}
