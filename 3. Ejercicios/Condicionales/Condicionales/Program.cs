using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30, b = 20;

            //BOOL
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            //Comparacion
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);


            //IF

            if (a > 0) Console.WriteLine("{0} Mayor que {1}", a, b);

            if (b >= 17)
            {
                Console.WriteLine("17 Menor que {0}", b);
            }


            //Division de numeros

            double dividendo, divisor, resultado;

            Console.Write("Ingrese dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("{0} / {1} = {2}", dividendo, divisor, resultado);
            }

            //If - ELSE
            //Edad
            byte edad;

            Console.Write("¿que edad tiens? : ");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

            //If Anidados
            // Variables
            decimal num1, num2, resultado1 = 0.0M;
            byte opcion;

            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Pedimos al usuario que escoja una opción
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos el primer número
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Suma
            if (opcion == 1)
            {
                resultado1 = num1 + num2;
            }
            //Resta
            if (opcion == 2)
            {
                resultado1 = num1 - num2;
            }
            // Multiplicación
            if (opcion == 3)
            {
                resultado1 = num1 * num2;
            }
            //División
            if (opcion == 4)
            {
                if (num2 != 0)
                {
                    resultado1 = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No es posible dividir entre cero!");
                }
            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado1);


            //Escalera If - Else

            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Pedimos al usuario que escoja una opción
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos el primer número
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Suma
            if (opcion == 1)
            {
                resultado1 = num1 + num2;
            }
            //Resta
            if (opcion == 2)
            {
                resultado1 = num1 - num2;
            }
            // Multiplicación
            if (opcion == 3)
            {
                resultado1 = num1 * num2;
            }
            //División
            if (opcion == 4)
            {
                if (num2 != 0)
                {
                    resultado1 = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No es posible dividir entre cero!");
                }
            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado1);


            //Operadores 
            // And = &&
            // Or = ||

            //Switch

            string color;

            Console.Write("Ingresa el color RGB para darte su codigo: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("El codigo RGB para {0} es: 255, 0, 0", color); 
                    break;
                case "Green":
                    Console.WriteLine("El codigo RGB para {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                    Console.WriteLine("El codigo RGB para {0} es: 0, 0, 255", color);
                    break;
                default:
                    Console.WriteLine("No se encontro el codigo RGB para el color {0}, intenta nuevamente.",color);
                    break;
            }




        }
    }
}
