using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class Configuracion
    {
        private string notificaciones;

        public Configuracion(string notificaciones)
        {
            this.notificaciones = notificaciones;
        }

        public string Notificaciones
        {
            get { return notificaciones; }
            set { notificaciones = value; }
        }

    }
}
