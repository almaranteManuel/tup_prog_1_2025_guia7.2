using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Realice un algoritmo que pida 5 valores al usuario y luego informe cual es el mayor de los ingresados.
// Restricción: la aplicación solo puede tener 2 variables.


namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, mayor;

            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            mayor = num;

            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("Ingrese un segundo número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("Ingrese un tercer número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("Ingrese un cuarto número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("Ingrese un quinto número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("El número mayor es: " + mayor);

            Console.ReadKey();
        }
    }
}
