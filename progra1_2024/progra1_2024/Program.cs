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
                string continuar = "s";
                while (continuar == "s")
                {
                    Console.WriteLine("***Menu de opciones***");
                    Console.WriteLine("opcion 1: Conversion de monedas");
                    Console.WriteLine("Opcion 2: Conversion de masas");
                    Console.WriteLine("Opcion 3: conversion de Volumen");
                    Console.WriteLine("Opcion 4: Conversion de Longitud");
                    Console.WriteLine("Opcion 5: Conversion de almacenamiento");
                    Console.WriteLine("Opcion 6: conversion de tiempo");
                    Console.WriteLine("Opcion 7: salir");
                    Console.Write("opcion: ");
                    int opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Cmonedas();
                            break;
                        case 2:
                            Cmasa();
                            break;

                        case 3:
                            Cvolumen();
                            break;

                        case 4:
                            Lconvertir();
                            break;
                        case 5:
                            Calmacenamiento();
                            break;
                        case 6:
                            Ctiempo();
                            break;

                        case 7:

                            continuar = "n";
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                            break;
                    }
                    Console.ReadLine();
                }
            }
            static void Cmonedas()
            {

                string[] monedas = { "Dólar", "Euro", "Peso MX", "Peso col", "Córdobas", "Quetzal", "Lempira", "Yenes", "Libras Esterlinas", "Pesos Arg" };
                double[] tasasMoneda = { 1, 0.85, 17.20, 4174.89, 36.42, 7.72, 24.67, 148.65, 0.76, 365.20 };

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("escoge la moneda que quieres convertir:");
                    for (int i = 0; i < monedas.Length; i++)
                        Console.WriteLine($"{i + 1}. {monedas[i]}");
                    int maconvertir = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (maconvertir < 0 || maconvertir >= monedas.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    Console.WriteLine("Elegiste la opción {0}. a que moneda lo quieres convertir", maconvertir + 1);
                    for (int i = 0; i < monedas.Length; i++)
                        Console.WriteLine($"{i + 1}. {monedas[i]}");
                    int mconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (mconvertida < 0 || mconvertida >= monedas.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    Console.Write("que cantidad deseas convertir: ");
                    double cantidad = double.Parse(Console.ReadLine() ?? "0");
                    double resultado = cantidad * (tasasMoneda[mconvertida] / tasasMoneda[maconvertir]);
                    Console.WriteLine($"{cantidad} {monedas[maconvertir]} = {resultado} {monedas[mconvertida]}");


                    return;

                }

            }

            static void Lconvertir()
            {

                Console.Clear();
                string[] unidad =
                {"Metro", "Kilometro", "Hectometro", "Decametro", "Decimetro", "Centimetro", "Milimetro", "Pies", "Pulgadas", "Yardas" };
                double[] longitud =
               {1, 1000, 100, 10, 0.1, 0.01, 0.001, 0.3048, 0.254, 0.9144  };
                while (true)
                {
                    Console.WriteLine("Seleccione la unidad que desea convertir:");
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertir = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (Uaconvertir < 0 || Uaconvertir >= unidad.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    Console.WriteLine("Elegiste la opción {0}. ahora elige la unidad a la que lo quieres convertir:", Uaconvertir + 1);
                    for (int i = 0; i < unidad.Length; i++)
                        Console.WriteLine($"{i + 1}. {unidad[i]}");
                    int Uaconvertida = int.Parse(Console.ReadLine() ?? "0") - 1;
                    if (Uaconvertida < 0 || Uaconvertida >= unidad.Length)
                    {
                        Console.WriteLine("Opción no válida.");
                        continue;
                    }
                    Console.Write("escribe la unidad que deseas convertir: ");
                    double Lconvertir = double.Parse(Console.ReadLine() ?? "0");
                    double resultado = Lconvertir * (longitud[Uaconvertir] / longitud[Uaconvertida]);
                    Console.WriteLine($"{Lconvertir} {unidad[Uaconvertir]} = {resultado} {unidad[Uaconvertida]}");
                    return;
                }



            }
            static void Ctiempo()

            {
                Console.Clear();
                double[,] conversion = {
            { 1, 60, 3600, 3.6e+6, 3.6e+9, 3.6e+12, 0.0416667, 0.00138889, 2.77778e-7, 1.15741e-8 },
            { 1.0/60, 1, 60, 6e+4, 6e+7, 6e+10, 0.000694444, 2.31481e-5, 4.62963e-9, 1.92901e-10 },
            { 1.0/3600, 1.0/60, 1, 1e+6, 1e+9, 1e+12, 1.15741e-5, 3.85802e-7, 7.71605e-11, 3.21502e-12 },
            { 2.77778e-7, 1.66667e-5, 1.0/1e+6, 1, 1000, 1e+6, 3.22158e-13, 1.06888e-14, 2.13777e-18, 8.89849e-20 }
        };
                string[] unidades = {
            "Horas",
            "Minutos",
            "Segundos",
            "Microsegundos",
            "Milisegundos",
            "Nanosegundos",
            "Días",
            "Semanas",
            "Meses",
            "Años"
        };
                Console.WriteLine("Seleccione la unidad de origen:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {unidades[i]}");
                }
                int origen = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Seleccione la unidad de destino:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {unidades[i]}");
                }
                int destino = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Ingrese el valor: ");
                double valor = double.Parse(Console.ReadLine());
                // Cálculo de la conversión
                double resultado = valor * conversion[origen, destino];
                Console.WriteLine($"Resultado: {resultado} {unidades[destino]}");
                Console.ReadLine();
                return;
            }
            static void Calmacenamiento()
            {
                Console.Clear();
                double[,] conversion = {
            { 1, 1e+6, 1e+9, 1e+12, 1024, 1.049e+6, 1.074e+9, 1.1e+12, 1.25, 0.001 },
            { 1e-6, 1, 1e+3, 1e+6, 0.001, 1024, 1.049e+6, 1.074e+9, 1.25e-6, 1e-9 },
            { 1e-9, 1e-3, 1, 1e+3, 1e-6, 1.024, 1024, 1.049e+6, 1.25e-9, 1e-12 },
            { 1e-12, 1e-6, 1e-3, 1, 1e-9, 1.024e-3, 1.024, 1024, 1.25e-12, 1e-15 }
        };
                string[] unidades = {
            "Gigabytes",
            "Kilobytes",
            "Bytes",
            "Terabytes",
            "Megabytes",
            "Kibibytes",
            "Mebibytes",
            "Gibibytes",
            "Petabytes",
            "Exabytes"
        };
                Console.WriteLine("Seleccione la unidad de origen:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {unidades[i]}");
                }
                int origen = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Seleccione la unidad de destino:");
                for (int i = 0; i < unidades.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {unidades[i]}");
                }
                int destino = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Ingrese el valor: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = valor * conversion[origen, destino];
                Console.WriteLine($"Resultado: {resultado} {unidades[destino]}");
                Console.ReadLine();
                return;
            }
            static void Cmasa()
            {
                Console.Clear();
                var conversiones = new Dictionary<string, double>
        {
            { "gramos", 1e-3 },
            { "kilogramos", 1 },
            { "libras", 0.453592 },
            { "onzas", 0.0283495 },
            { "toneladas", 1e3 },
            { "miligramos", 1e-6 },
            {"microgramos", 1e-9 },
            { "toneladas métricas", 1e3 },
            { "toneladas cortas", 907.185 },
            { "stone", 6.35029 }
        };
                var unidades = new List<string>(conversiones.Keys);
                Console.WriteLine("Conversores de Masa:");
                Console.WriteLine("Ingrese la cantidad:");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Seleccione la unidad de entrada:");
                MostrarOpciones(unidades);
                int unidaduno = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Seleccione la unidad de salida:");
                MostrarOpciones(unidades);
                int unidaddos = Convert.ToInt32(Console.ReadLine()) - 1;
                string entrada = unidades[unidaduno];
                string salida = unidades[unidaddos];
                double resultado = cantidad * conversiones[entrada] / conversiones[salida];
                Console.WriteLine($"La cantidad de {cantidad} {entrada} es equivalente a {resultado} {salida}.");
                Console.ReadLine();
                return;
            }
            static void MostrarOpciones(List<string> opciones)
            {
                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }
            }
            static void Cvolumen()
            {
                var conversion = new Dictionary<string, double>
        {
            { "kilómetros cúbicos", 1e18 },
            { "hectómetros cúbicos", 1e15 },
            { "decámetros cúbicos", 1e12 },
            { "metros cúbicos", 1e9 },
            { "decímetros cúbicos", 1e6 },
            { "centímetros cúbicos", 1e3 },
            { "milímetros cúbicos", 1 }
        };
                Console.Clear();
                var unidades = new List<string>(conversion.Keys);

                Console.WriteLine("Conversor de Volumen: ");
                Console.WriteLine("Ingrese la cantidad a convertir: ");
                double cantidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Seleccione el dato de entrada:");
                MostrarOp(unidades);

                int Entrada = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Seleciones el dato de salida:");
                MostrarOp(unidades);

                int Salida = Convert.ToInt32(Console.ReadLine()) - 1;

                string entrada = unidades[Entrada];
                string salida = unidades[Salida];

                double resultado = cantidad * conversion[entrada] / conversion[salida];

                Console.WriteLine($"La cantidad de {cantidad} {entrada} es equivalente a {resultado} {salida}.");
                Console.ReadLine();
                return;
            }
            static void MostrarOp(List<string> opciones)
            {
                for (int i = 0; i < opciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }

            }
        }
}   }