using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio,angulo, radianes, conversionX, conversionY;

            Console.WriteLine("Ingrese el valor del radio: ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del angulo: ");
            angulo = double.Parse(Console.ReadLine());
          
            radianes = (angulo * Math.PI) / 180;
            Console.WriteLine($"El valor del angulo se cambia a radianes: {radianes}");
            
            conversionX = RectangularX(radio, radianes);
            conversionY = RectangularY(radio, radianes);

            Console.WriteLine($"Las coordenadas rectangulares resultantes son ({conversionX}, {conversionY})");

            Console.ReadKey();
        }
        static double RectangularX(double pradio, double pradianes)
        {
            double resultado = 0;
            resultado = pradio * (Math.Cos(pradianes));
            resultado = Math.Truncate(resultado * 100) / 100;
            return resultado;
        }
        static double RectangularY(double pradio, double pradianes)
        {
            double resultado = 0;
            resultado = pradio * (Math.Sin(pradianes));
            resultado = Math.Truncate(resultado * 100) / 100;
            return resultado;
        }
    }
    
}
