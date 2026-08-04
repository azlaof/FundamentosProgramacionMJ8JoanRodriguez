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
            float dato5 = 4 + 6* (2 - 1);
            float dato6= dato2 * dato3 -dato4 / dato5;

            //operadores logicos 
            //conjunción - AND - Y - &&
            Console.WriteLine("------------TABLA DE LA CONJUNCIÓN------------");
            Console.WriteLine("V && = " + (true && true));
            Console.WriteLine("V && = " + (true && false));
            Console.WriteLine("V && = " + (false && true));
            Console.WriteLine("V && = " + (false && false));
            Console.WriteLine("-----------------------------------------------");


        }
    }
}
