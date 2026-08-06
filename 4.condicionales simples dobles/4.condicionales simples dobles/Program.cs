using System;

namespace _4.condicionales_simples_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad=Convert.ToByte( Console.ReadLine());
            if (edad >= 18) 
            {
                Console.WriteLine("Bienvenido a mi sitio web");

            }*/

            float sueldo;
            string nombre;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo > 3000) ;
            {
                Console.WriteLine(nombre+" debe abonar impuestos");
            }
        


        }
    }
}
