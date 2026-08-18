using System;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta =0;
            Console.WriteLine("------------------menu------------------");
            Console.WriteLine("1. Opción 1    2. Opción 2");
            Console.WriteLine("3. Opción 3    4. Opción 4");
            Console.WriteLine("5. Opción 5");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Elija una opción del menú:");
            respuesta=int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio opción 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio opción 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio opción 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio opción 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio opción 5");
                    break;
                default:
                    Console.WriteLine("Elija una opción valida");
                    break;

            }



        }
    }
}
