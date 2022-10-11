using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Persona> integrantes;
        private string nombre;

        private Equipo()
        {
            integrantes = new List<Persona>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public List<Persona> Integrantes { get { return integrantes; } }


        public static bool operator +(Equipo e, Persona p)
        {
            if ((!(e.integrantes.Contains(p))) && e.integrantes.Count < e.cantidadDeJugadores)
            {
                e.integrantes.Add(p);
                return true;
            }
            return false;
        }
    }
}
