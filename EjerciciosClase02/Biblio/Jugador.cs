using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre){}

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float PromedioGoles { get { return partidosJugados / totalGoles; ; } }
        public int TotalGoles { get { return totalGoles; } }
        public int PartidosJugados { get { return partidosJugados; } }

        public override string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"DNI: {DNI}");
            retornoFuncion.AppendLine($"NOMBRE: {Nombre}");
            retornoFuncion.AppendLine($"PARTIDOS JUGADOS: {partidosJugados}");
            retornoFuncion.AppendLine($"TOTAL GOLES: {totalGoles}");
            retornoFuncion.AppendLine($"PROMEDIO DE GOLES: {PromedioGoles}");
            return retornoFuncion.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.DNI.Equals(j2.DNI))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.DNI.Equals(j2.DNI))
            {
                return false;
            }
            return true;
        }
    }
}
