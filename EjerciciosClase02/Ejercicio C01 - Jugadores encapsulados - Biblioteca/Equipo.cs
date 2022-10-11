using System;
using System.Collections.Generic;

namespace Ejercicio_C01___Jugadores_encapsulados___Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public List<Jugador> Jugadores { get { return jugadores; } }


        public static bool operator +(Equipo e, Jugador j)
        {
            if ((!(e.jugadores.Contains(j))) && e.jugadores.Count < e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
