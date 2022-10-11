using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private static int codigo;
        private string nombre;
        private int precioDelProducto;

        public Producto()
        {
            codigo = 0;
        }

        public Producto(string nombre, int precioDelProducto) : this()
        {
            this.nombre = nombre;
            this.precioDelProducto = precioDelProducto;
            codigo++;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int PrecioDelProducto
        {
            get
            {
                return this.precioDelProducto;
            }
        }
    }
}
