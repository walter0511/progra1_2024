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
       
            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine()); //7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            //TAREA: Obtener la nota final por computo y Nota Final de la matera de Programacion I.


            //Pausa.
            Console.ReadLine();

        }
    }
}
