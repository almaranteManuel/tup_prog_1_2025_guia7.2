using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El número es cero");
            }
            else
            {
                Console.WriteLine("El número es positivo");
            }
        }
    }
}
