using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class Pedido
    {
        public Pedido()
        {
        }
        private string fecha;
        public string Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        private string numerodeentrega;
        public string Numerodeentrega
        {
            get { return this.numerodeentrega; }
            set { this.numerodeentrega = value; }
        }
        private Cliente cliente;
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        private List<PizzaPorPedido> pizzasPorPedido;
        public List<PizzaPorPedido> PizzasPorPedido
        {
            get { return this.pizzasPorPedido; }
            set { this.pizzasPorPedido = value; }
        }
    }
}