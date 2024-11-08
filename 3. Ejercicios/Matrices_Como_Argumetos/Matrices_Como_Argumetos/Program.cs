using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Como_Argumetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matriz unidimensional con asignacion implicita de tipo
            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Invocamos al metodo
            ImprimirMatriz(matriz);


            //Matriz Multi

            double[,] matriz2D = { { 1,2 },
                                  { 3,4 } };

            //Invocamos al metodo
            ImprimirMatrizMulti(matriz2D);


        }

        //Metodo que imprime los valores de la matriz
        static void ImprimirMatriz(int[] matrizPa)
        {
            int i;
            for(i = 0; i < matrizPa.Length; i++) 
            {
                Console.WriteLine(matrizPa[i]);
            }
        }

        //Metodo que imprime los valores de la matriz multi
        static void ImprimirMatrizMulti(double[,] matriz2DPa)
        {
            int i, j;

            for (i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine("Fila {0}", i);
                for (j = 0; j < matriz2DPa.GetLength(1); j++) 
                {
                    Console.WriteLine(matriz2DPa[i,j]);
                }
            }
        }
    }
}
