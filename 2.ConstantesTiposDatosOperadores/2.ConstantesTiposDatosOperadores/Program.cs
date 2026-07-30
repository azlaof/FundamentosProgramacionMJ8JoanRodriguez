using System;

namespace _2.ConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string iva="19%";
            string nombre = "Joan";
            nombre = "Sebastian";
            // iva = "20%"; es una constante no la puedo cambiar
            byte dato1 = 225;
            int dato2 = -12365;
            long dato3 = 123565656;
            float dato4 = 5.3f;
            double dato5 = 12.36;
            decimal dato6 = 125636.46436482m;
            char dato7 = '¿';
            string dato8 = "dato8 -*/*969-*/*'9373";
            bool dato9 = true;
            object dato10 = new object ();
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}",dato11, dato12);
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es:{0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("La resta es:{0}",dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("La multiplicación es:{0}",dato15);
            float dato16 = (float)5 / 3;
            Console.WriteLine("La división es:{0}",dato16);
   
        }
    }
}
