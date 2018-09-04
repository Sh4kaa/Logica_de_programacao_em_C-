using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double novoSalario, salario, per;
            string[] vet;
            vet = Console.ReadLine().Split(' ');

            salario = double.Parse(vet[0], CultureInfo.InvariantCulture); 

            if ( salario <= 400)
            {
                per = 15;
                novoSalario = salario + (salario * per) / 100;
            } else
            {
                if (salario > 400 && salario <= 800)
                {
                    per = 12;
                    novoSalario = salario + (salario * per) / 100;
                } else
                {                    
                    if ( salario > 800 && salario <= 1200)
                    {
                        per = 10;
                        novoSalario = salario + (salario * per) / 100;

                    } else
                    {
                        if (salario > 1200 && salario <= 2000)
                        {
                            per = 7;
                            novoSalario = salario + (salario * per) / 100;
                        }
                        else
                        {
                            per = 4;
                            novoSalario = salario + (salario * per) / 100;
                        }
                    }
                }

                
            }           

            
            Console.WriteLine("Novo salario: "+ novoSalario.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+ (novoSalario - salario).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + per +" %");
            Console.ReadLine();

            /*  Dica: pegar o valor do salario, multiplicar pelo valor do percentual de
             *  acordo com a tabela e dividir por 100 ai terá o valor do novo salario.
             *  para saber o reajuste é só fazer (novo salario menos o salario) */
             

        }
    }
}
