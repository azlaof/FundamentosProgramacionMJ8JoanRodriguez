using System;
namespace Parcial_de_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cálculo del aumento salarial de un empleado
Desarrolle un programa en C# que determine el porcentaje y el valor del aumento salarial que corresponde a un empleado, teniendo en cuenta los años trabajados en la empresa y el promedio de sus calificaciones de desempeño de los dos últimos años. (70%)
Ingreso de datos
El programa debe solicitar al usuario los siguientes datos:
Nombre del empleado.
Número de años trabajados en la empresa, expresado como un número entero mayor o igual a 0.
Calificación del año actual.
Calificación del año anterior.
Las calificaciones únicamente pueden tomar uno de los siguientes valores:
0.0, 0.4, 0.6 o 1.0
Validación de las calificaciones
El programa debe verificar que tanto la calificación del año actual como la del año anterior correspondan a uno de los valores permitidos.
Si alguna de las dos calificaciones no es válida, el programa debe mostrar:
Error: calificación inválida. El programa terminará.
En este caso, el programa debe finalizar y no debe realizar el cálculo del promedio ni del aumento salarial.
Cálculo del promedio
Si las calificaciones son válidas, el programa debe calcular el promedio de las dos calificaciones mediante la siguiente fórmula:
promedioCalificación = (calificaciónActual + calificaciónAnterior) / 2
Determinación del porcentaje de aumento
El porcentaje de aumento salarial se determina de acuerdo con los siguientes criterios:


Años trabajados
Promedio de calificación
% de aumento
0
Cualquier promedio
0%
Más de 5
Cualquier promedio
30%
De 1 a 5
0.0 ≤ promedio < 0.4
5%
De 1 a 5
0.4 ≤ promedio < 0.6
10%
De 1 a 5
0.6 ≤ promedio ≤ 1.0
20%
Importante: cuando el empleado tiene más de 5 años trabajados, el porcentaje de aumento es del 30%, independientemente de su promedio de calificación.
Cálculo del aumento
Todos los empleados tienen un sueldo base de:
$2.500.000
El valor del aumento debe calcularse mediante la siguiente fórmula:
valorAumento = sueldoBase × (porcentajeAumento / 100)
Salida del programa
Si las calificaciones son válidas, el programa debe mostrar en pantalla:
Nombre del empleado.
Promedio de calificación.
Porcentaje de aumento aplicado.
Valor del aumento en pesos.
Los valores monetarios deben mostrarse de manera clara y comprensible para el usuario.*/

            string nombre;
            int añosTrabajados;
            double calificacionActual;
            double calificacionAnterior;

            double sueldoBase = 2500000;
            double promedioCalificacion;
            double porcentajeAumento = 0;
            double valorAumento;

            Console.Write("Nombre del empleado:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese los años trabajados: ");
            añosTrabajados = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del año actual: ");
            calificacionActual = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la calificación del año anterior: ");
            calificacionAnterior = double.Parse(Console.ReadLine());

            bool calificacionActualValida =
                calificacionActual!= 0.0 &&
                calificacionActual!= 0.4 &&
                calificacionActual!= 0.6 &&
                calificacionActual!= 1.0;

            bool calificacionAnteriorValida =
              calificacionAnterior!= 0.0 &&
              calificacionAnterior!= 0.4 &&
              calificacionAnterior!= 0.6 &&
              calificacionAnterior!= 1.0;
            if (!calificacionActualValida && !calificacionAnteriorValida)
            {
                Console.WriteLine("Error: Calificación inválida. El programa terminará");
                return;
            }

            promedioCalificacion = (calificacionActual + calificacionAnterior) / 2;
            if (añosTrabajados!= 0)
            {
                porcentajeAumento = 0;
            }
            else 
                if (añosTrabajados > 5)
            {
                porcentajeAumento = 30;
            }
            else 
                 if (promedioCalificacion < 0.4)
            {
                porcentajeAumento = 5;
            }
            else 
                 if (promedioCalificacion < 0.6)
            {
                porcentajeAumento = 10;
            }
            else
            {
                porcentajeAumento = 20;
            }
            valorAumento = sueldoBase * (porcentajeAumento / 100);
            Console.WriteLine("------ RESULTADOS -----");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Promedio de calificación:" + promedioCalificacion);
            Console.WriteLine("Porcentaje de aumento:" + porcentajeAumento + "%");
            Console.WriteLine("Valor del aumento" + valorAumento.ToString("no"));
        }

    }
}