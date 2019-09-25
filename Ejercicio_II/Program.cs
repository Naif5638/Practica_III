using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Ingrese el valor [{0},{1}]: ", i + 1, j + 1);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.Write(matriz[matriz.GetLength(0) - matriz.GetLength(0), i]);
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.Write(matriz[matriz.GetLength(0) - 1, i]);
            }
            
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine(matriz[i, matriz.GetLength(0) - matriz.GetLength(0)]);
            }

            Console.ReadKey();
        }
    }
}
