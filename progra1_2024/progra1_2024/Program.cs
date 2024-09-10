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
            //uso de funciones
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Menú Principal:");
                    Console.WriteLine("1. Calcular Impuesto de Actividades Económicas");
                    Console.WriteLine("2. Conversor de Unidades de Área");
                    Console.WriteLine("3. Salir");
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Calcularimpuesto();
                            break;
                        case 2:
                            Conversorarea();
                            break;
                        case 3:
                            Console.WriteLine("Saliendo del programa...");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
                    Console.ReadKey();
                }
            }

            static void Calcularimpuesto()
            {
                Console.Clear();
                Console.WriteLine("Impuesto De Actividades Económicas");
                Console.Write("Ingrese el valor económico de la actividad: ");
                decimal actividad = Convert.ToDecimal(Console.ReadLine());

                decimal rango = 1000.01m;
                decimal valorf = 1000m;
                decimal adicional = 3m;
                decimal precio = 3m;
                decimal monto;

                decimal diferencia = actividad - rango;
                monto = (diferencia / valorf) * adicional + precio;

                Console.WriteLine("El valor económico de la actividad económica es: $" + actividad);
                Console.WriteLine("Monto a pagar es: $" + monto.ToString("F2"));
            }

            static void Conversorarea()
            {
                var conversion = new Dictionary<string, double>
        {
            { "Pie Cuadrado", 0.0929 },
            { "Vara Cuadrada",  0.698896  },
            { "Yardas cuadrada", 0.836127 },
            { "Metro cuadrado", 1 },
            { "Tareas", 1000 },
            { "Manzana", 7050 },
            { "Hectarea", 10000 }
        };

                Console.Clear();
                var unidades = new List<string>(conversion.Keys);

                Console.WriteLine("Seleccione el dato de entrada:");
                mostraropciones(unidades);

                int Entrada = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Conversor de Unidades de Área: ");
                Console.Write("Ingrese la cantidad a convertir: ");
                double cantidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Seleccione el dato de salida:");
                mostraropciones(unidades);

                int Salida = Convert.ToInt32(Console.ReadLine()) - 1;

                string entrada = unidades[Entrada];
                string salida = unidades[Salida];
                double resultado = cantidad * conversion[entrada] / conversion[salida];

                Console.WriteLine($"La cantidad de {cantidad} {entrada} es equivalente a {resultado} {salida}.");
            }

            static void mostraropciones(List<string> opciones)
            {
                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }
            }   }
}   }