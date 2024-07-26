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
            int num1, num2;
            Console.WriteLine("Digite un número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite otro número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("La suma es: {0}", (num1 + num2).ToString());
            Console.ReadKey();
        }
    }
}
