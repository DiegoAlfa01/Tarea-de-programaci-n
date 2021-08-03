using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class problema2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a continuación se hara un calculo matetematico por favor llenar los campos requeridos de a y b  ");
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Ingrese el valor 'a'");
            Console.WriteLine(".................................................................\n");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Ingrese el valor 'b'");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("el valor de (a+b)*(a-b) es igual:");
            Console.WriteLine((a + b) * (a - b));
            Console.ReadKey();


        }


    }
}
