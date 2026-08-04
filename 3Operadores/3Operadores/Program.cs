using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //orden de evaluación operadores numéricos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4 / 3 * 2;
            float dato3 = 4f * (2f / 3);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato2);

            //OPERADORES LOGICOS
            //Conjuncion - AND - Y - &&
            Console.WriteLine("TABLA CONJUNCION0")
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("---------------------");
            //Operador logico de negacion !
            bool dato8 = true;
            bool dato9 = !dato8;

            //OPERADORES DE COMPARACION
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;

        }
    }
}
