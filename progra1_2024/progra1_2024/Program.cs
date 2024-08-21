using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra1_2024
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un bebe");
                }
                else if (edad < 12)
                {
                    Console.WriteLine("Eres un niño");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un adolescente.");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Larga vida");
                }
                Console.Write("Desea continuar presione s, sino cualquier tecla.");
                continuar = Console.ReadLine();
            }
        }
    }
}
