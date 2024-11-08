using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llamando clases Publicas
            //Variable local
            bool acelerar;

            //Instanciando a la clase Automovil
            Automovil automovil1 = new Automovil();


            automovil1.color = "Rojo";
            automovil1.combustible = "Diesel";

            Console.WriteLine("El tipo de cobustible es: {0}", automovil1.combustible);

            acelerar = automovil1.Acelerar();

            if (acelerar)
            {
                Console.WriteLine("Acelerando correctamente");
            }

            Automovil.Prueba();
            Console.WriteLine("Aqui termina llamado clase publica");


            //Llamando clases Privadas

            Automovil_Pri automovil_Pri1 = new Automovil_Pri();

            //Mostrando un campo privado
            Console.WriteLine("El color es: {0}", automovil_Pri1.ColorM1);

            //Asignandole un valor a un campo privado
            automovil_Pri1.CombustibleM1 = "Gasolina";
            Console.WriteLine("El combustible es: {0}", automovil_Pri1.CombustibleM1);
        }
    }

    // [ Modificador de acceso] [Clase] [Identificador]

    //Publico
    public class Automovil
    {

        //Campos 
        public string color, modelo, combustible;
        public byte año, numPuertas;
        public int ccMotor;

        //Metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            Prueba();
            return acelerar;
        }

        public bool Frenar()
        {
            bool frenar = true;
            Console.WriteLine("Frenar");
            return frenar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de velocidad");

        }

        //Metodo estatico

        public static void Prueba()
        {
            Console.WriteLine("Soy un metodo estatico");
        }
    }


    //Privado
    public class Automovil_Pri
    {

        //Campos 
        private string color1="Azul", modelo1, combustible1;
        private byte año1, numPuertas1;
        private int ccMotor1;

        //Propiedades
        //[acceso] [tipo] [Nombre]
        public string ColorM1
        {
            //Accesors
            
            //descriptor de acceso "get"
            get { return color1; }
        }

        public string CombustibleM1
        {
            //descriptor de acceso "get"
            get { return combustible1; }

            //descriptor de acceso "set"
            set { combustible1 = value; }
        }


        //Metodos
        public bool Acelerar1()
        {
            bool acelerar1 = true;
            Console.WriteLine("Acelerar");
            Prueba();
            return acelerar1;
        }

        public bool Frenar1()
        {
            bool frenar1 = true;
            Console.WriteLine("Frenar");
            return frenar1;
        }

        public void Velocidades1(ref byte velocidadPa1)
        {
            velocidadPa1++;
            Console.WriteLine("Cambio de velocidad");

        }

        //Metodo estatico

        public static void Prueba()
        {
            Console.WriteLine("Soy un metodo estatico");
        }
    }




}
