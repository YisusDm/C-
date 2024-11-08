using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Escalonada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables Ciclos
            int i, j;

            /*
            //Declaracion matriz escalonado forma logica
            //Tipo [][] nombre = new tipo [Filas][];
            double[][] ventas = new double[4][];

            //Declaracion de las matrices internas
            ventas[0] = new double[3] { 155, 100, 170 };
            ventas[1] = new double[2] { 205, 120 };
            ventas[2] = new double[4] { 115, 190, 104, 130 };
            ventas[3] = new double[3] { 163, 218, 125 };
            */


            //Declaracion matriz escalonado forma abreviada
            //Tipo [][] nombre = new tipo [Filas][];
            double[][] ventas2 = new double[][]
            {
                new double[3] { 155, 100, 170 },
                new double[2] { 205, 120 },
                new double[4] { 115, 190, 104, 130 },
                new double[3] { 163, 218, 125 }
            };

            for (i = 0; i < ventas2.Length; i++)
            {
                Console.WriteLine("Elemento: {0}", i);
                for (j = 0; j < ventas2[i].Length; j++)
                {
                    Console.WriteLine(ventas2[i][j]);
                }
            }







        }
    }
}
