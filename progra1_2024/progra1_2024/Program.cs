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
            //ejercicio obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
            int suma = 0;
            foreach (int num in serie)

                suma += num;
            //estructuras de control.
            //1. if. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
            else
                Console.WriteLine("Eres un adolescente, disfruta de la vida.");

            decimal prom = suma / serie.Length;
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);

            //Pausa.
            Console.ReadLine();
        }
    }
}
