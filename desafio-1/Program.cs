using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Moto ROKR W5", "Motorola");

            Console.WriteLine("Escriba el número de télefono:");
            t1.NumeroTelefonico = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de operador (1, 2 o 3)");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("Modelo: " + t1.Modelo);
            Console.WriteLine("Marca: " + t1.Marca);
            Console.WriteLine("Número telefonico: " + t1.NumeroTelefonico);
            if (t1.CodigoOperador == 0)
            {
            Console.WriteLine("Código de operador: Código no valido" );
            }
            else
            {
            Console.WriteLine("Código de operador: " + t1.CodigoOperador);
            }
            
            Console.ReadKey();

            Console.WriteLine(t1.Llamar());

            
            Console.WriteLine("A quien desea llamar?");
            string contacto = Console.ReadLine();
            Console.WriteLine(t1.Llamar(contacto));

            Console.ReadKey();

            Contactos c1 = new Contactos("Pepito","45569731","De la olla 123");

            Console.WriteLine("Mostrando datos el contacto...");
            c1.Mostrar();

            Console.WriteLine("Desea actualizar el número de telefono?");
            bool act = bool.Parse(Console.ReadLine());

            if(act)
            {
                Console.WriteLine("Ingrese el nuevo número de telefono:");
                string nuevo = Console.ReadLine();
                c1.Actualizar(nuevo);

                Console.WriteLine("Mostrando datos actualziados...");
                c1.Mostrar();
            }
            Console.ReadKey();
        }
    }
}
