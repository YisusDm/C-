using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencia_VS_Valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo 1 ref
            byte NumAr1 = 10;
            Console.WriteLine(NumAr1);

            Prueba1(ref NumAr1);
            Console.WriteLine(NumAr1);

            //Medodo 2 out
            byte NumAr2;
            string saludoAr2;
            int numPromoAr2;

            Prueba2(out NumAr2, out saludoAr2, out numPromoAr2);
            Console.WriteLine(NumAr2);
            Console.WriteLine(saludoAr2);
            Console.WriteLine(numPromoAr2);
        }

        static void Prueba1(ref byte NumPa)
        {
            NumPa = 20;
        }

        static void Prueba2(out byte NumPa, out string saludoPa, out int numPrimoPa)
        {
            NumPa= 25;
            saludoPa = "Hola a todos";
            numPrimoPa = 7;

        }


    }
}
