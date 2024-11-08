using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i;//Variable control del ciclo

            //Matrices unidimiencionales

            // Tipo [] nombre;
            //int[] numeros = new int[10];
            //byte[] datos = new byte[7];



            double[] calificaciones = new double[4] { 8, 7.1, 4, 6 };//Declaracion de una matriz tipo double

            //Imprimir datos de la matriz
            for (i = 0; i <= 3; i++)
            {
                Console.WriteLine(calificaciones[i]);
            }


            string[] nombres = new string[5];
            
            //Insertando datos en la matriz
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Ingrese el valor para el indice {0}: ", i + 1);
                nombres[i] = Console.ReadLine();
            }

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(nombres[i]);
            }



        }
    }
}
