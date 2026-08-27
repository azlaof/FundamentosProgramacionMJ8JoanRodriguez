using System;

namespace _9.ciclos_while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnum = 0;//numeros a ingresar
            int num = 0;
            int cnumm = 0;//contador mayores
            int cnumme = 0;//contador menores
            int cnumi = 0;// contador iguales
            int numin = 0;// numeros ingresados

            Console.WriteLine("Cuantos números va a ingresar? pedazo de aborto de mico");
            cnum=int.Parse(Console.ReadLine());
            if (cnum == 1 && num == 67)
            {
                Console.WriteLine("Coma mierda hijueputa");
            }

            while (numin < cnum)
            {
                 numin ++;
                Console.WriteLine("ingrese el numero que le de la perra hijueputa gana");
                num= int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cnumm++;
                }
                else
                {
                    if (num < 0)
                    {
                        cnumme++;
                    }
                    else
                    { 
                      cnumi++;
  
                    }
                    
                }
            }
            Console.WriteLine("Los hijueputas numeros mayores son:" + cnumm);
            Console.WriteLine("Los números que le dio la gana de meter menor a 0 son:" + cnumme);
            Console.WriteLine("Los numeros de mierda iguales a 0 son:" + cnumi);
        }
    }
}
