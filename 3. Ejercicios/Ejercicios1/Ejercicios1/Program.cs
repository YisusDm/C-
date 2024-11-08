using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alto, ancho, area, perimetro;

            Console.Write("Ingrese la altura del rectangulo: ");
            alto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el ancho del rectangulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculando area ....");
            area = alto * ancho;

            Console.WriteLine("Calculando perimetro ....");
            perimetro = (alto+ ancho) * 2; 


            Console.WriteLine("El area del rectangulo es: {0}", area);
            Console.WriteLine("El perimetro del rectangulo es: {0}", perimetro);
        }
    }
}
