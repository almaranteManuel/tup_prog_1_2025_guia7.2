using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ingresado el nombre de los jugadores y el resultado de cada set (3) de un partido de tenis, informe en pantalla cuál es el ganador.
// Ejemplo: Nadal, Del Potro: 7,5,4,6,6,2
// Ganador Nadal


namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string jugador1, jugador2;
            int set1j1, set2j1, set3j1, set1j2, set2j2, set3j2;
            int setGanadosj1 = 0;
            int setGanadosj2 = 0;

            Console.WriteLine("Ingrese el nombre del jugador 1:");
            jugador1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del jugador 2:");
            jugador2 = Console.ReadLine();

            Console.WriteLine("Ingrese el resultado del primer set (jugador 1):");
            set1j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del primer set (jugador 2):");
            set1j2 = Convert.ToInt32(Console.ReadLine());

            if (set1j1 > set1j2)
            {
                setGanadosj1 += 1;
            }
            else if (set1j2 > set1j1)
            {
                setGanadosj2 += 1;
            }

            Console.WriteLine("Ingrese el resultado del segundo set (jugador 1):");
            set2j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del segundo set (jugador 2):");
            set2j2 = Convert.ToInt32(Console.ReadLine());

            if (set2j1 > set2j2)
            {
                setGanadosj1 += 1;
            }
            else if (set2j2 > set2j1)
            {
                setGanadosj2 += 1;
            }

            Console.WriteLine("Ingrese el resultado del tercer set (jugador 1):");
            set3j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del tercer set (jugador 2):");
            set3j2 = Convert.ToInt32(Console.ReadLine());

            if (set3j1 > set3j2)
            {
                setGanadosj1 += 1;
            }
            else if (set3j2 > set3j1)
            {
                setGanadosj2 += 1;
            }

            if (setGanadosj1 > setGanadosj2)
            {
                Console.WriteLine($"Ganador: {jugador1}");
            }
            else if (setGanadosj2 > setGanadosj1)
            {
                Console.WriteLine($"Ganador: {jugador2}");
            }
            else
            {
                Console.WriteLine("El partido terminó en empate.");
            }

            Console.ReadKey();
        }
    }
}
