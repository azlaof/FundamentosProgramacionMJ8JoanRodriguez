using System;


namespace _17.ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Areglos bidimensionales o matrices
            /*int[,] numeros = new int[2,3];

            //numeros[2, 1] = 10; no se puede almacenar porque el índice la fila no existe
            //numeros[1, 3] = 15; no se puede almacenar porque el índice la columna no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 100;
            numeros[0, 2] = 56;
            numeros[1, 0] = 45;
            numeros[1, 1] = 8;
            numeros[1, 2] = 10;

            Console.WriteLine($"El valor almacenado en numeros[1,0]: {numeros[1, 0]}");
            //Recorrer para llenar
            char[,] simbolos = new char[3,2];
            for (int i = 0; i < 3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el caracter para simbolos [{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar datos

            for(int i=0; i<simbolos.GetLength(0);i++)//GetLength(0) devuelve el número de filas
            {
                for(int j=0; j<simbolos.GetLength(1);j++)//GetLenght(1) devuelve el número de columnas
                {
                    Console.WriteLine($"{simbolos[i, j]}|");
                }
                Console.WriteLine();
            }

            //Otra forma de declarar e inicializar matrices
            string[,] nombres = {
                                  { "Ana", "Juan", "Carlos", "Álvaro" },
                                  { "Pedro", "Ferney", "Yuli", "Félix" },
                                  { "Carla", "Alex", "Esteban", "Salomé" }
                                };

            //1. Crear una matriz[10,20], en cada posición de la matriz poner el número 100;
            //mostrar la matriz en consola
            int[,] matriz = new int[10, 20];

            for(int i=0;i<10; i++)
            {
                for( int j=0; j<20; j++)
                {
                    matriz[i, j] = 100;
                    Console.WriteLine($"{matriz[i, j]}|");
                }
                Console.WriteLine();
            }*/

            //2. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3, primero solicite al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas, luego, lo mismo para la segunda matriz, segundo, calcule la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices, y finalmente muestre la matriz resultante de la suma en formato de matriz, 2 filas 3 columnas
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            int[,] Resultado= new int[2,3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para A[{i},{j}]:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para B[{i},{j}]:");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Resultado[i, j] = A[i, j] + B[i, j];
                    Console.WriteLine($"La matriz resultado de la suma de A y B es: [{i},{j}]={Resultado[i, j]}");
                }
            }

        }
    }
}
