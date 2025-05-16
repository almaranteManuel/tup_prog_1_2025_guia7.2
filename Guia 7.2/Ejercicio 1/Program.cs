using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota necesaria para la promoción");
            double notaPromo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del primer examen");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo examen");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer examen");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= notaPromo)
            {
                Console.WriteLine("El alumno está promovido");
            }
            else
            {
                Console.WriteLine("El alumno no está promovido, rinde final");
            }
        }
    }
}
