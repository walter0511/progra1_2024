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
            double[,] matriz = new double[,] {
                {0.01, 487.6, 0, 0 },
                {487.61, 642.85, 10, 17.48},
                {642.86, 915.81, 10, 32.70},
                {915.82, 2058.67, 20,60.00},
                {2058.68, 9999999, 30, 288.57},
            };
            Console.Write("sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());
            double afp = sueldo * 6.25 / 100;
            sueldo -= afp;

            double isr = 0;
            for (int i = 0; i < 5; i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
            }

            sueldo -= isr;
            Console.WriteLine("Sueldo: {0}, AFP: {1}, ISR: {2}", sueldo, afp, isr);

            Console.ReadLine();

        }
    }
}