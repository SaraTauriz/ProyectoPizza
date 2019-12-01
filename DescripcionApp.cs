using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class DescripcionApp
    {
        private string descripcion;

        public DescripcionApp(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

    }
}
