using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I05___Prueba_de_geometría
{
    public class Punto
    {
        private int x;
        private int y;
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
