using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contPar=0, contImpar=0, contPos=0, contNeg=0, n;
            
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contPar++;
            } else
            {
                contImpar++;
            }
            if (n < 0 )
            {
                contNeg++;
            } else if (n > 0)
            {
                contPos++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contPar++;
            }
            else
            {
                contImpar++;
            }
            if (n < 0)
            {
                contNeg++;
            }
            else if (n > 0)
            {
                contPos++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contPar++;
            }
            else
            {
                contImpar++;
            }
            if (n < 0)
            {
                contNeg++;
            }
            else if (n > 0)
            {
                contPos++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contPar++;
            }
            else
            {
                contImpar++;
            }
            if (n < 0)
            {
                contNeg++;
            }
            else if (n > 0)
            {
                contPos++;
            }

            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                contPar++;
            }
            else
            {
                contImpar++;
            }
            if (n < 0)
            {
                contNeg++;
            }
            else if (n > 0)
            {
                contPos++;
            }



            Console.WriteLine(contPar + " valor(es) par(es)");
            Console.WriteLine(contImpar + " valor(es) impar(es)");
            Console.WriteLine(contPos + " valor(es) positivo(s)");
            Console.WriteLine(contNeg + " valor(es) negativo(s)");


            Console.ReadLine();





        }
    }
}
