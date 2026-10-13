using System;


namespace _8.CiclosWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
            //El agoritmo debe escrbir en pantalla:
            //La cantidad de números introducidos que son mayores que 0
            //La cantidad de números introducidos menores que 0
            //La cantidad de números iguales a 0
            /*int positivos = 0;
            int negativos = 0;
            int nulos = 0;
            int numero = 0;
            int cantidad = 0;

            Console.WriteLine("Ingrese la cantidad de números que va a ingresar");
            cantidad = int.Parse(Console.ReadLine());
            if(cantidad<=0)
            {
                Console.WriteLine("Error, cantidad ingresada no valida");
                Environment.Exit(0);
            }
            Console.WriteLine($"Ingrese de uno en uno los {cantidad} números");
            while (cantidad > 0)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    if(numero>0)
                    {
                        positivos++;
                    }
                    else
                    {
                        nulos++;
                    }
                }
                else
                {
                    negativos++;
                }
                cantidad--;
            }
            Console.WriteLine($"De los números ingresados hay {positivos} positivos, {negativos} negativos y {nulos} nulos.");*/

            //Escribir un algoritmo que cuente cuántos números pares hay en un rando de números del 1 al número n. (función mod en c#)
            int n = 0;
            int contador = 1;
            int pares = 0;
            int impares = 0;
            Console.WriteLine("Ingrese hasta qué número desde el 1 desea averiguar cuántos números pares e impares hay");
            n = int.Parse(Console.ReadLine());
            while (contador <= n)
            {
                contador++;
                int residuo = contador % 2;
                if (residuo == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine($"Del número 1 hasta el {n} hay {pares} números pares y {impares} números impares");

        }
    }
}
