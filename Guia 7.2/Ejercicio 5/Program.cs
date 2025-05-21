using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Realice un algoritmo que pida 5 valores al usuario y luego informe cual es el número de orden en que se ingresó el menor de ellos.
// Restricción: la aplicación solo puede tener 3 variables.


namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, menor, ordenMenor;

            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            menor = num;
            ordenMenor = 1;

            Console.WriteLine("Ingrese un segundo número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                ordenMenor = 2;
            }

            Console.WriteLine("Ingrese un tercer número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                ordenMenor = 3;
            }

            Console.WriteLine("Ingrese un cuarto número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                ordenMenor = 4;
            }

            Console.WriteLine("Ingrese un quinto número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                menor = num;
                ordenMenor = 5;
            }

            Console.WriteLine("El número menor es: " + menor + " ,en orden " + ordenMenor);

            Console.ReadKey();
        }
    }
}
