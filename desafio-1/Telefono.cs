using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        private string modelo;
        private string marca;
        private int numeroTelefonico;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca
        {
            get { return marca; }
        }

        public int NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set{
                if (value <= 3 && value >= 1)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        /*public void Llamar()
        {
            Console.WriteLine("Realizando llamada...");
        }*/

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }
    }
}
