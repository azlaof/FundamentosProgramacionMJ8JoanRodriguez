using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Samuel");
            MostrarMensaje("Samuel", "Arango Giraldo");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedmientos sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }
    }
}
