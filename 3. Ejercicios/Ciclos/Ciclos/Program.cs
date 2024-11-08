using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i; //Operando

            //i = 10;

            //Console.WriteLine("Valor inicial del operando: {0}", i);

            ////Incremento como prefijo e imprimimos
            //Console.WriteLine("Valor con incremento incluido: {0}", ++i);

            ////Ya no incrementamos, solo imprimimos
            //Console.WriteLine(i);

            //int n = 20;

            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine("Valor inicial del operando: {0}", n);

            ////Decremento como sufijo e imprimimos
            //Console.WriteLine("Valor con incremento incluido: {0}", n--);

            ////Ya no incrementamos, solo imprimimos
            //Console.WriteLine(n);


            ////Ciclo For 

            ////Variable de bucle (o de control)

            //int init,acum=0;

            //for (init = 1; init <= 10; init++)
            //{
            //    Console.WriteLine(init);
            //    acum += init;

            //}
            //Console.WriteLine("Acumulado: {0}", acum);

            ////Ciclo While

            //byte numero = 1;

            //while (numero <= 10)
            //{
            //    Console.WriteLine(numero);
            //    numero++;

            //}

            //string contraseña1, contraseña2 = "";

            //Console.Write("Escribe tu contraseña: ");
            //contraseña1 = Console.ReadLine();

            //while (contraseña1 != contraseña2)
            //{
            //    Console.Write("Confirma tu contraseña: ");
            //    contraseña2 = Console.ReadLine();
            //}
            //Console.WriteLine("¡Contraseña Guardada!");


            //Ciclo Do-While

            //int ii = 15;

            //do
            //{
            //    Console.WriteLine(ii);
            //    ii++;
            //}
            //while (ii <= 10);


            // Iteracion anidadas --Tabla Multiplicacion 1 al 10

            int j; //Varible bucle exterior 
            int k; //variable bucle interior
            int resultado; //gurada valor de multiplicacion

            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("Tabla de multiplicacion del {0}", j);//nos muestra la tabla actual

                for (k = 1; k <= 10; k++)
                {
                    resultado = j * k;
                    Console.WriteLine("{0} * {1} = {2}",j,k,resultado);
                }
            }



        }
    }
}
