using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class PizzaPorPedido
    {
        public PizzaPorPedido()
        {
        }
        private Pizza pizza;
        public Pizza Pizza
        {
            get { return this.pizza; }
            set { this.pizza = value; }
        }
        private Pedido pedido;
        public Pedido Pedido
        {
            get { return this.pedido; }
            set { this.pedido = value; }
        }
        private List<Ingrediente> ingredientes;
        public List<Ingrediente> Ingredientes
        {
            get { return this.ingredientes; }
            set { this.ingredientes = value; }
        }
    }
}