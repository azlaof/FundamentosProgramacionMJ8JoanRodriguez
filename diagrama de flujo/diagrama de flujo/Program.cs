using System;

namespace diagrama_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Debe ingresar 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del numero 1");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El numero 1 es mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es mayor");
                }

            }
            else
            {
                if (num2 > num1)
                {
                    Console.WriteLine("El numero 2 es mayor");
                }
                else
                {
                    Console.WriteLine("el numero 3 es mayor");
                }

            }


        }
    }
}
