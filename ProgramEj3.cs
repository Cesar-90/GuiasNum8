using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia8Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo opcion;
            do
            {
                Console.WriteLine("a) Dividir");
                Console.WriteLine("b) Obtener Cubo");
                Console.WriteLine("c) Cálculo de IMC");
                Console.WriteLine("d) Salir.");
                opcion = Console.ReadKey(true);

                switch (opcion.Key)
                {
                    case ConsoleKey.A:
                        break;

                    case ConsoleKey.B:
                        break;

                    case ConsoleKey.C:
                        break;

                    case ConsoleKey.D:
                        break;

                    default:
                        Console.Write("Ingrese una de las opciones dadas en el menú");
                        break;
                }
            } while (opcion.Key != ConsoleKey.D);

        }
        public static void Dividir()
        {
            double num1, num2;
            Console.WriteLine("Ingrese el valor del num1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del num2: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"El total de la división entre en los dos numeros es: {num1 / num2}");
        }
        public static void Cubo()
        {
            double num1;
            Console.WriteLine("Ingrese el valor del numero: ");
            num1 = double.Parse(Console.ReadLine());
            num1 = Math.Pow(num1, 3);

            Console.WriteLine($"El total del cubo es: {num1}");
        }
        public static void Imc()
        {
            double kg=0, mt=0, resultado;
            Console.WriteLine("Ingrese el valor de kilogramos: ");
            kg = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de metros: ");
            mt = double.Parse(Console.ReadLine());

            resultado = (kg * Math.Pow(mt, 2));
        }
    }
}
