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
            Conversores objConversor = new Conversores();
            String continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("::.. MENU ..::");
                Console.WriteLine("1. Monedas.");
                Console.WriteLine("2. Longitud.");
                Console.WriteLine("3. Masa.");
                Console.WriteLine("4. Tiempo.");
                Console.WriteLine("0. Salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                {
                    continuar = "n";
                }
                else
                {
                    for (int i = 1 < objConversor.etiquetas[opcion].lenght; i++) {

                  
                    }
                    Console.WriteLine("{0}. {1}", i, objConversor.etiquetas[opcion][i]);
                    Console.Write("De: ");
                    int de = int.Parse(Console.ReadLine());

                    Console.Write("A: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    double cantidad = double.Parse(Console.ReadLine());

                    Console.WriteLine("{0} \n", objConversor.convertir(de, a, cantidad, opcion));
                }
            }
        }
}   }