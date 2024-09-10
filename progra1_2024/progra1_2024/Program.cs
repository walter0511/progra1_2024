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
            //Uso de funciones...
            Console.WriteLine("La suma de 10+5={0}", suma());

            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, suma(num1, num2));

            Console.ReadLine();
        }
        static int suma()
        {
            int respuesta = 10 + 5;
            return respuesta;
        }
        static int suma(int a, int b)
        {
            int respuesta = a + b;
            return respuesta;


        }




    }
   
}