using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPizza.Clases
{
     public class Factura
    {
        
        private string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        private int numerodePedido;

        public int NumerodePedido
        {
            get { return numerodePedido; }
            set { numerodePedido = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string descripciondeCompra;

        public string DescripciondeCompra
        {
            get { return descripciondeCompra; }
            set { descripciondeCompra = value; }
        }
        private double pedidofinal;

        public double Pedidofinal
        {
            get { return pedidofinal; }
            set { pedidofinal = value; }
        }


        private double subtotal;

        public double Subtotal
        {
            get { return Precio * Pedidofinal; }
        }
        public double IVA
        {
            get { return Subtotal * 12 / 100; }
        }
        public double Total
        {
            get { return Subtotal + IVA; }
        }

    }
}
