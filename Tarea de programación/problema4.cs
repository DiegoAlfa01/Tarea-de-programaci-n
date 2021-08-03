using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class problema4
    {
        static void Main(string[] args)
        {
            //Convertir grados Centigrados a Fahrenheit
            //Sabiendo que F = (9/5)*c+32
            //declaración de variables
            double c, f;

            //Ingreso de los datos
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Ingresar Cantidad de Grados Centigrados: ");
            Console.WriteLine("\n..................................................................");
            c = Convert.ToDouble(Console.ReadLine());

            //Conversión de grados centigrados a fahrenheit
            f = (9 / 5) * c + 32;

            //Salida de datos
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Resultados en Grados Fahrenheit: " + f);
            Console.WriteLine("\n..................................................................");
            Console.ReadKey();
        }


    }
}
