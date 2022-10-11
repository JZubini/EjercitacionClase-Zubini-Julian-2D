using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private int codigoProducto;
        private string nombre;
        private double precioProducto;

        public Producto(int codigoProducto, string nombre, double precioProducto)
        {
            this.codigoProducto = codigoProducto;
            this.nombre = nombre;
            this.precioProducto = precioProducto;
        }

        public int CodigoProducto { get { return codigoProducto; } }
        public string Nombre { get { return nombre; } }
        public double PrecioProducto { get { return precioProducto; } }


    }
}
