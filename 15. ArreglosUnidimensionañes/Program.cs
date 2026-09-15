using System;
namespace _15.ArreglosUnidimensionañes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            numeros[0] = 15
            numeros[1] = 56;
            numeros[2] = 20;
            numeros[3] = 47;
            numeros[4] = 27;

            Console.WriteLine($"El dato almacenado en la posicion 4 con indice 3 es; {numeros[3]}");

            float[] notas = new float[3];
            notas[0] = 3.6f;
            notas[1] = 4.3f;
            notas[2] = 5.0f;
            char[] simbolos = new char[] { '?', '(', '5', 'f' };
            bool[] valoresVerdaderos = { true, false, true, true, false, };

            string[] nombres = new string[7];

            for (int i = 0; i < 7; i++) ;
            {
                Console.WriteLine($"Ingrese el nombre para la P{i + 1}:I{i}");
                nombres[i]=Console.ReadLine();

                for (int i = 0; i < nombres.Length; i++) ;
                {
                    Console.WriteLine($"{nombres[i]}|");    
                }
            }
        }
    }
}
