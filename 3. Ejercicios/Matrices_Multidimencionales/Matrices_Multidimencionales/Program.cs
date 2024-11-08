using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Multidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Declaracion
            //Tipo[,] nombre = new tipo [Filas, Columnas]  -> Matriz 2 dimenciones

            double[,] ventas = new double[4, 3];

            //Tipo[,,] nombre = new tipo [Filas, Columnas, profundidad]  -> Matriz 3 dimenciones

            double[,,] ventasAño = new double[5, 3, 3];

            **********************************************************************************/

            //variables

            int i, j;


            /* Inicializacion matriz 2 dimenciones */

            double[,] ventas = new double[4, 3] { {100, 120, 205},
                                                  {115, 196, 300},
                                                  {157, 172, 245},
                                                  {130, 180, 281} };

            //Mostrar longitud de las dimenciones de la matriz
            Console.WriteLine("Filas: {0}, Columnas: {1}",ventas.GetLength(0), ventas.GetLength(1));


            /* Imprimir Matriz 2 dimenciones */

            for(i = 0; i < ventas.GetLength(0); i++)
            {
                Console.WriteLine("Fila {0}", i);
                for (j = 0; j < ventas.GetLength(1); j++) 
                {
                    Console.WriteLine(ventas[i, j]);
                }
            }





            /* Inicializacion matriz 3 dimenciones */

            int[,,] Matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
                                                  { { 7, 8, 9 }, { 10, 11, 12 } } };


        }
    }
}
