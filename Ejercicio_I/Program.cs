using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Una empresa tiene dos turnos (mañna y tarde)");
            Console.WriteLine("********************************************");
            double[] turnoMatutino = new double[4];
            double[] turnoVerpertino = new double[4];
            double sueldoTarde = 0.0, sueldoMan = 0.0;
            Console.WriteLine("Ingresar sueldo de empleados turno de la mañana: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresar sueldo: ");
                turnoMatutino[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIngresar sueldo de empleados turno de la tarde: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresar sueldo: ");
                turnoVerpertino[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n******************************************************");
            Console.WriteLine("Calculo de Gastos: ");
            Console.WriteLine("********************************************************");
            for (int i = 0; i < 4; i++)
            {
                sueldoMan += turnoMatutino[i];
                sueldoTarde += turnoVerpertino[i];
            }

            Console.WriteLine("Gastos en sueldos del turno de la mañana: {0}", sueldoMan);
            Console.WriteLine("Gastos en sueldos del turno de la tarde: {0}", sueldoTarde);
            Console.ReadKey();

        }
    }
}
