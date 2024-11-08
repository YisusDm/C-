using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////text
            //Console.WriteLine("Jesus David Marquez");

            ////variable
            //string saludo = "Hola";
            //Console.WriteLine(saludo);

            ////usuaro de variables en cadena de texto
            //double precioCamisa = 399;
            //string colorCamisa = "Azul";

            //Console.WriteLine("El precio de la camisa es: {0} y su color es: {1}", precioCamisa, colorCamisa);

            ////variable operadores

            //double a, b, c;
            //a = 5; b = 7;

            ////Operador suma

            //Console.WriteLine("suma", a + b);
            //c = a + b;
            //Console.WriteLine(c);

            ////Operador Resta
            //Console.WriteLine("Resta", a - b);
            //c = a - b;
            //Console.WriteLine(c);

            ////Operador Multiplicacion
            //Console.WriteLine("Multiplicacion", a * b);
            //c = a * b;
            //Console.WriteLine(c);

            ////Operador Divicion
            //Console.WriteLine("Divicion", a / b);
            //c = a / b;
            //Console.WriteLine(c);

            ////Operador Residio - Resto
            //Console.WriteLine("Residio - Resto", a % b);
            //c = a % b;
            //Console.WriteLine(c);

            //Ingreso nombre

            String nombre;
            Console.Write("¿como te llamas?: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}, un placer", nombre);


            //Ingreso Numero
            String entrada;
            int num1 = 5, num2, resultado;

            Console.Write("Dame un numero para sumarlo: ");

            ////Convertimos la cadena a entero
            //entrada = Console.ReadLine();
            //num2 = Int32.Parse(entrada);

            //Convertimos la cadena a entero metodo 2
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: {0}", resultado);






    }

    }
}
}
