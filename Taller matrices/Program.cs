using System;
using System.Runtime.Serialization.Formatters;
namespace Taller_matrices
{

    class Program
    {
        static void Main()
        {
            /*// 1. Declarar la matriz de 10 filas y 20 columnas
            int[,] matriz = new int[10, 20];

            // Objeto para generar números aleatorios (para rellenar la matriz con datos de prueba)
            Random random = new Random();

            // 2. Rellenar la matriz con valores aleatorios (por ejemplo, entre 1 y 100)
            for (int i = 0; i < matriz.GetLength(0); i++) // Recorre las filas (0 al 9)
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // Recorre las columnas (0 al 19)
                {
                    matriz[i, j] = random.Next(1, 100); // Número aleatorio entre 1 y 99
                }
            }
            // 3. Calcular y mostrar la suma de los elementos de cada columna
            Console.WriteLine("Suma de los elementos por cada columna:");

            // Invertimos los bucles: primero recorremos las columnas y dentro las filas
            for (int j = 0; j < matriz.GetLength(1); j++) // Para cada columna (0 al 19)
            {
                int sumaColumna = 0;

                for (int i = 0; i < matriz.GetLength(0); i++) // Sumamos cada fila de esa columna (0 al 9)
                {
                    sumaColumna += matriz[i, j];
                }

                Console.WriteLine($"Columna {j + 1}: {sumaColumna}");
            }*/
            int nc;
            int nf;
            Console.WriteLine("Ingrese la cantidad de filas que va a tener su matriz");
            nf = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas que va a tener su matriz");
            nc = int.Parse(Console.ReadLine());
            char[,] matriz = new char[nf, nc];
            for (int i = 0; i<matriz.GetLength(0); i++)
            {
                for (int j = 0;  j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor que desea almacenar en matriz[{i}, {j}]");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}
