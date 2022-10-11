using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Jugadores_encapsulados___Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private int promedioGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float PromedioGoles { get { return partidosJugados / totalGoles; ; } }
        public int TotalGoles { get { return totalGoles; } }
        public int PartidosJugados { get { return partidosJugados; } }

        public int DNI { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        
        public string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"DNI: {dni}");
            retornoFuncion.AppendLine($"NOMBRE: {nombre}");
            retornoFuncion.AppendLine($"PARTIDOS JUGADOS: {partidosJugados}");
            retornoFuncion.AppendLine($"TOTAL GOLES: {totalGoles}");
            retornoFuncion.AppendLine($"PROMEDIO DE GOLES: {PromedioGoles}");
            return retornoFuncion.ToString();
        }

        public float GetPromedioGoles()
        {
            return partidosJugados / totalGoles;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni.Equals(j2.dni))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.dni.Equals(j2.dni))
            {
                return false;
            }
            return true;
        }

    }
}
