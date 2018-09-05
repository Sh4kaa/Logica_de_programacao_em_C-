using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1049animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo1, tipo2, tipo3;

            tipo1 = Console.ReadLine();
            tipo2 = Console.ReadLine();
            tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado" && tipo2 == "mamifero" && tipo3 == "onivoro")
            {
                Console.WriteLine("homem");                
            } else if (tipo1 == "vertebrado" && tipo2 == "mamifero" && tipo3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            } else if (tipo1 == "vertebrado" && tipo2 == "ave" && tipo3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            } else if (tipo1 == "vertebrado" && tipo2 == "ave" && tipo3 == "onivoro")
            {
                Console.WriteLine("pomba");
            } else if (tipo1 == "invertebrado" && tipo2 == "inseto" && tipo3 == "hematofago")
            {
                Console.WriteLine("pulga");
            } else if (tipo1 == "invertebrado" && tipo2 == "inseto" && tipo3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            } else if (tipo1 == "invertebrado" && tipo2 == "anelideo" && tipo3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            } else
            {
                Console.WriteLine("minhoca");
            }
            Console.ReadLine();
            
        }
    }
}
