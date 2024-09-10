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

            //metro, kilometro, hectometro, decametro, decimetro, centimetro, milimetro, pies, pulgadas, yardas
            string[] unidad =
            {"Metro", "Kilometro", "Hectometro", "Decametro", "Decimetro", "Centimetro", "Milimetro", "Pies", "Pulgadas", "Yardas" }

            ;
            double[] longitud =
            {1, 1000, 100, 10, 0.1, 0.01, 0.001, 0.3048, 0.254, 0.9144  }

            ;

            while (true)
            {
                Console.WriteLine("Seleccione la unidad de longitud que desea convertir");
                for (int i = 0; i < unidad.Length; i++)
                    Console.WriteLine($"{i + 1}. {unidad[i]}");
                int Uaconvertir = int.Parse(Console.ReadLine() ?? "0") - 1;
                if (Uaconvertir < 0 || Uaconvertir >= unidad.Length)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }
                Console.WriteLine("Elegistes la opcion {0} ahora selecciona a que unidad lo deseas convertir", Uaconvertir);
                for (int i = 0; i < unidad.Length; i++)
                    Console.WriteLine($"{i + 1}. {unidad[i]}");
                int Uaconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;

                if (Uaconvertida < 0 || Uaconvertida >= unidad.Length)
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                Console.Write("Introduce la longitud que desees convertir: ");
                double Lconvertir = double.Parse(Console.ReadLine() ?? "0");



                double resultado = Lconvertir * (longitud[Uaconvertir] / longitud[Uaconvertida]);
                Console.WriteLine($"{Lconvertir} {unidad[Uaconvertir]} = {resultado} {unidad[Uaconvertida]}");

                Console.ReadLine();




            };


            Console.Write("Ingrese la serie de numeros separados por comas: ");
            String serie = Console.ReadLine();
            String[] numeros = serie.Split(',');

            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}; y la medida armonica es: {2}", media(numeros), tipica(numeros), armonica(numeros));

            Console.ReadLine();
        }
        static double media(string[] serie)
        {
            double media = 0;
            foreach (string num in serie)
            {
                media += int.Parse(num);
            }





            return media / serie.Length;
        }
        static double tipica(string[] serie)
        {
            double tipica = 0,
                     m = media(serie);
            foreach (string num in serie)
            {
                tipica += Math.Pow(int.Parse(num) - m, 2);
            }
            tipica = Math.Sqrt(tipica / serie.Length);
            return Math.Round(tipica);
        }
        static double armonica(string[] serie)
        {
            double armonica = 0;
            foreach (string num in serie)
            {
                armonica += 1 / int.Parse(num);
            }
            armonica = serie.Length / armonica;
            return Math.Round(armonica);
        }
    }
}