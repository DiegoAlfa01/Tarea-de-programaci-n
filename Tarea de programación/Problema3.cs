using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class Problema3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar numeros enteros para realizar la siguiente división");
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Realize los siguientes campos para a y b");
            Console.WriteLine("\n..................................................................");
            Console.WriteLine("Ingrese el dato para 'a'");
            Console.WriteLine(".................................................................\n");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("\n..................................................................");
            Console.WriteLine("Ingrese el dato para 'b'");
            Console.WriteLine(".................................................................\n");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n..................................................................");

            if (b == 0)
            {

                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {

                var division = (a / b);
                Console.WriteLine("La división resultante entre a y b es: ");
                Console.WriteLine(division);


            }

            Console.ReadKey();



        }



    }
}
