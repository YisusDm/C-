using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.

            byte mes;

            Console.Write("Ingresa el número del que quieres conocer el mes: ");
            mes = Convert.ToByte(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                default:
                    Console.WriteLine("Ese número de mes no existe");
                    break;
            }


            // Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

            long numero;

            Console.Write("Dame un número y te diré si es par o impar: ");
            numero = Convert.ToInt64(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }


        }
    }
}
