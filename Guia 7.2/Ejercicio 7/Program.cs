using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implemente un algoritmo que permita determinar si un año es bisiesto o no.
Un año es bisiesto si es múltiplo de 4 (por ejemplo 1984). Los años múltiplos de 100 no son bisiestos, 
salvo si ellos son también múltiplos de 400 (2000 es bisiesto, pero; 1800 no lo es).*/


namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;

            Console.WriteLine("Ingrese un año:");
            anio = Convert.ToInt32(Console.ReadLine());

            if (anio % 4 == 0)
            {
                if (anio % 100 != 0 || anio % 400 == 0)
                {
                    Console.WriteLine("El año " + anio + " es bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año " + anio + " no es bisiesto.");
                }
            } 
            else
            {
                Console.WriteLine("El año " + anio + " no es bisiesto.");
            }

            Console.ReadKey();
        }
    }
}
