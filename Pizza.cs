using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class Pizza
    {
        public Pizza()
        {
        }
        private string tipo;
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        private string tamaño;
        public string Tamaño
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
        }
        private float precio;
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
    }
}