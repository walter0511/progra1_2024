using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); 
            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); 
            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); 
          
            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); 
            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); 
            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine()); 
            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);


            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); 
            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); 
            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine()); 
            double c3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", c3);


            Console.Write("c1, c2, c3 ");
            double suma =  c1 + c2 + c3;
            double promedio = suma / 3;
            Console.WriteLine("la suma de las notas es: {0}",suma );
            Console.WriteLine("el promedio de las notas es: {0}",promedio);
            

            


            
            Console.ReadLine();
        }
    }
}           