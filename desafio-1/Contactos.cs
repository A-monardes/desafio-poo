using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    internal class Contactos
    {
        private string nombre;
        private string telefono;
        private string direccion;

        public Contactos (string nombre, string telefono, string direccion)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Dirección: " + direccion);
        }

        public void Actualizar(string nuevoTelefono)
        {   
            telefono = nuevoTelefono;
            Console.WriteLine("Telefono actualizado con exito.");   
        }
    }
}
