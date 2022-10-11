using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool validarKeyVacia(List<int> productosSinStock,int respuestaUsuario)
        {
            foreach (int item in productosSinStock)
            {
                if(item == respuestaUsuario)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
