using Prueba.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Escriba un nombre");
            estudiante.Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba un apellido");
            estudiante.Apellido = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escriba su cedula");
            estudiante.Cedula = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El estudiante digitado es de nombre {0} con apellido {1} y cedula {2}", estudiante.Nombre, estudiante.Apellido, estudiante.Cedula);
            Console.ReadKey();
        }
    }
}
