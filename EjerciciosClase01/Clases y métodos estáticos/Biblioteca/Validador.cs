using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor > min && valor < max)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarRespuesta(string respuestaUsuario)
        {
            if(respuestaUsuario == "S")
            {
                return true;
            }
            return false;
        }
    }
}
