using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Luis";
            byte edad = 50;
            long numero = 52121545;
            int dirPostal = 231122;

            //(Tipo) Identificado = (Valor);


            //Tupla declarando variables
            (string, byte, long, int) persona1 = ("Luis", 50, 52121545, 231122);

            Console.WriteLine(persona1);
            //Item
            Console.WriteLine(persona1.Item1,persona1.Item2,persona1.Item3,persona1.Item4);

            //Tupla variables declardas automaticas
            var persona2 = (nombre: "Carlos", edad: 35, numero: 529467, DirPostal: 110548);
            //(string nombre, byte edad, long numero, int DirPostal) persona1 = ("Luis", 50, 52121545, 231122);

            Console.WriteLine(persona2.nombre, persona2.edad, persona2.numero, persona2.DirPostal);

        }
    }
}
