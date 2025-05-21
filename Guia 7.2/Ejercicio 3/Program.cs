using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Se ingresa el nombre y Número de libreta de 3 alumnos. Muestre la lista ordenada por Número de libreta.
namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9;
            string a1, a2, a3;

            Console.WriteLine("ingrese el nombre del primer alumno");
            a1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ahora ingrese las 3 notas del primer alumno");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el nombre del segundo alumno");
            a2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ahora ingrese las 3 notas del segundo alumno");
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine());
            n6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el nombre del tercer alumno");
            a3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ahora ingrese las 3 notas del tercer alumno");
            n7 = Convert.ToInt32(Console.ReadLine());
            n8 = Convert.ToInt32(Console.ReadLine());
            n9 = Convert.ToInt32(Console.ReadLine());

            float prom1 = (n1 + n2 + n3) / 3;
            float prom2 = (n4 + n5 + n6) / 3;
            float prom3 = (n7 + n8 + n9) / 3;

            if (prom1 > prom2)
            {
                if (prom1 > prom3)
                {
                    if (prom3 > prom2)
                    {
                        Console.WriteLine("las notas ordenadas quedaria: " + prom1, prom3, prom2);
                    }
                    else
                    {
                        Console.WriteLine("las notas ordenadas quedarian: " + prom1, prom2, prom3);
                    }
                }
                else
                {
                    Console.WriteLine("las notas ordenadas quedarian: " + prom3, prom1, prom3);
                }
            }
            else
            {
                if (prom2 > prom3)
                {
                    if (prom3 > prom1)
                    {
                        Console.WriteLine("las notas ordenadas quedarian: " + prom2, prom3, prom1);
                    }
                    else
                    {
                        Console.WriteLine("las notas ordenadas quedarian: " + prom2, prom1, prom3);
                    }

                }
                else
                {
                    Console.WriteLine("las notas ordenadas quedarian: " + prom3, prom2, prom1);
                }
            }

            Console.ReadKey();
        }
    }
}
