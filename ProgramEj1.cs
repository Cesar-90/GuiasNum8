using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia8Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Resultado();
            Console.ReadKey();
            
        }
        static void Resultado()
        {
            int añoNacimiento, añoActual, edad;
            Console.WriteLine("Ingrese el año actual: ");
            añoActual = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año en que nació: ");
            añoNacimiento = int.Parse(Console.ReadLine());

            edad = añoActual - añoNacimiento;
            Console.WriteLine($"Su edad es la resta de su año de nacimiento con el año actual, usted tiene {edad} años");
        }
    }
}
