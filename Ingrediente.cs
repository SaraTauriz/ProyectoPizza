﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class Ingrediente
    {
        public Ingrediente(string nombre)
        {
            this.Nombre = nombre;
        }
        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}
