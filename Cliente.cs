using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
 
        public class Cliente
        {
            public Cliente(string nombre, string apellido)
            {
                Nombre = nombre;
              Apellido = apellido;
            }
            private string nombre;
            public string Nombre
            {
                get { return this.nombre; }
                set { this.nombre = value; }
            }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        private List<Pedido> pedidos;
            public List<Pedido> Pedidos
            {
                get { return this.pedidos; }
                set { this.pedidos = value; }
            }
        }
}
