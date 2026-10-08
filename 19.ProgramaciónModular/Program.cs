using System;
namespace _19.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }
        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La suma de los números ingresados es:{Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los números ingresados es:{Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicación de los números ingresados es:{Multiplicación()}");
                        break;
                    case 4:
                        Console.WriteLine($"La división de los números ingresados es:{División()}");
                        break;
                }
            }
            while (opcion != 0)
            { 
            Console.ReadKey();
            Console.Clear();
            MostrarMenu();
            opcion = CapturarOpcion();
            }
            

        }
        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }

        static float Multiplicación()
        {
            float multiplicacion= 1 ;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir multiplicando (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Resta()
        {
                Console.WriteLine("Ingrese un número: ");
                float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un número: ");
                float numero2 = float.Parse(Console.ReadLine());

                return numero1 - numero2;

        }

        static float División()
        {
            Console.WriteLine("Ingrese un número: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            float numero2 = float.Parse(Console.ReadLine());

            return numero1/numero2;

        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("---------------------MENÚ----------------------");
            Console.WriteLine("1. Suma                   2. Resta");
            Console.WriteLine("3. Multiplicación         4. División");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ingrese una opción del menú: ");
        }
    }
}       