using System;

namespace _3.operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 0;
            dato1++;
            dato1--;
            dato1 += 5;
            dato1 *= 3;
            dato1 /= 2;
            dato1 += dato1;

            float dato2 = 4 / 3 * 2;
            float dato3 = 4 * (2 / 3);
            float dato4 = 4 + 6 * 2;
            float dato5 = 4 + 6 * (2 - 1);
            float dato6 = dato2 * dato3 - dato4 / dato5;

            //operadores logicos 
            //conjunción - AND - Y - &&
            Console.WriteLine("------------TABLA DE LA CONJUNCIÓN------------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("-----------------------------------------------");

            //DISYUNCION - OR- O - ||
            Console.WriteLine("------------TABLA DE LA CONJUNCIÓN------------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("-----------------------------------------------");

            bool dato7 = true;
            bool dato8 = !dato7;
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 25 == 25;
            bool dato12 = 4 != 4;
            bool dato13 = 5 < 4 && dato7;
            bool dato14 = 0 == 1 || 12 > 3 && dato9;
        }
    }
}
