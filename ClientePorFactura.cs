using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
    public class ClientePorFactura
    {
        public ClientePorFactura()
        {
        }
        private Cliente cliente;
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        private Factura factura;
        public Factura Factura
        {
            get { return this.factura; }
            set { this.factura = value; }
        }
        private List<Pedido> pedidos;
        public List<Pedido> Pedidos
        {
            get { return this.pedidos; }
            set { this.pedidos = value; }
        }
    }
}

