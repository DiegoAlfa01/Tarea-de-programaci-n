using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = " "; // Declaramos la cadena que almacenara el nombre
            string Cadena = " "; // Delcaramos una cadea...
            Console.WriteLine("Hola Buenos dias. ¿Como te llamas?"); // Muestra mensaje en pantalla.
            Console.WriteLine(".................................................................\n");
            nombre = Console.ReadLine(); //Espera que se escriba una linea en la pantalla y se presione enter.
            Console.WriteLine("\n..................................................................");
            Console.WriteLine("Mucho gusto " + nombre + ". Es todo un placer haberte conocido.");// muestra mensaje
            Console.WriteLine("....................................................................");
            Console.ReadKey(); // Espera que se presione una tecla.


        }
    }
}
// Diego Alejandro Martinez Chicas - Sofia Gissell Hernandez Ascencio