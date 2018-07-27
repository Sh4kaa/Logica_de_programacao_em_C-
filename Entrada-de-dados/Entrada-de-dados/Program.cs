using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {  
            string x;
            int y;
            double z;
            char w;
            
            // Entrada de dados

            /*lendo a atribuindo variáveis de acordo com o seu tipo
             * as vezes precisamos converter usando <tipo_davariavel>.Parse para converter de string para o formato desejado*/
             
            x = Console.ReadLine();   //comando readline lê uma linhha depois faz uma quebra de linha e fica esperando vc apertar alguma tecla
            y = int.Parse(Console.ReadLine());  //convertendo de inteiro para texto
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  //CultureInfo.InvariantCulture faz com que apareça uma virgula independente da localidade, região etc..
            w = char.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture)); //"F2" notaçaõ para duas casas decimais
            Console.WriteLine(w);
            Console.ReadLine();   

            //Lendo Varios dados na mesma linha

            string x;
            int y;
            double z;
            string[] vet = Console.ReadLine().Split(' '); // split faz separação com espaço de acordo com oq especificar, no exemplo é um espaço em branco
            // armazenando os valores em variaveis de acordo com as posições do vetor
            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
