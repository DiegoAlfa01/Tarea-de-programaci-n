using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class Problema5
    {
        static void Main(string[] args)
        {
            Double impuesto, precio, preconimpuesto;
            int producto;
            Console.WriteLine(".................................................................\n");
            Console.Write("--Menu de opciones");
            Console.Write("\n1) ESPECIAS");
            Console.Write("\n2) SNACKS");
            Console.Write("\n3) MEDICINA");
            Console.Write("\nSelecciona una opcion: ");
            Console.WriteLine("\n..................................................................");
            producto = Int32.Parse(Console.ReadLine());
            Console.WriteLine(".................................................................\n");
            Console.Write("\nIngresa el impuesto (%): ");
            Console.WriteLine("\n..................................................................");
            impuesto = double.Parse(Console.ReadLine());

            if (producto == 1 || producto == 2)
            {
                Console.WriteLine(".................................................................\n");
                Console.Write("\nIngrese el precio del producto: ");
                Console.WriteLine("\n..................................................................");
                precio = double.Parse(Console.ReadLine());
                preconimpuesto = ((impuesto / 100) * precio) + precio;
                Console.WriteLine(".................................................................\n");
                Console.WriteLine("\nEl precio del producto es: " + preconimpuesto);
                Console.WriteLine("\n..................................................................");
            }

            else if (producto == 3)
            {
                Console.WriteLine(".................................................................\n");
                Console.Write("\nIngrese el precio del producto: ");
                Console.WriteLine("\n..................................................................");
                precio = double.Parse(Console.ReadLine());
                Console.WriteLine(".................................................................\n");
                Console.WriteLine("\nEl precio del producto es: " + precio);
                Console.WriteLine("\n..................................................................");
            }
            else
            {
                Console.WriteLine(".................................................................\n");
                Console.WriteLine("\nEl producto no esta disponible");
                Console.WriteLine("\n..................................................................");
            }

            Console.ReadKey();
        }





    }
}
