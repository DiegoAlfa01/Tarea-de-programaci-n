using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_programación
{
    class Problema6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 3 notas para hacer el calculo de la nota final");
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Ingrese la primera nota equivalente al 35% de la calificación final");
            Console.WriteLine(".................................................................\n");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota equivalente al 30% de la calificación final");
            Console.WriteLine(".................................................................\n");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("Ingrese la tercera nota equivalente al 25% de la calificación final");
            Console.WriteLine(".................................................................\n");
            var c = double.Parse(Console.ReadLine());

            var nota1 = a * 0.35;
            var nota2 = b * 0.30;
            var nota3 = c * 0.25;
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("La nota final es: ");

            var NotaFinal = nota1 + nota2 + nota3;


            Console.WriteLine(NotaFinal);
            Console.WriteLine(".................................................................\n");
            Console.WriteLine("el 10% restante de la nota final corresponde a la asistencia ");
            Console.WriteLine(".................................................................\n");
            Console.ReadKey();

        }



    }
}
