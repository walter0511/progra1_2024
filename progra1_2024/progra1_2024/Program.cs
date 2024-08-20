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
            Console.Write("Num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);

            //Pausa.
            Console.ReadLine();

        }
    }
}
