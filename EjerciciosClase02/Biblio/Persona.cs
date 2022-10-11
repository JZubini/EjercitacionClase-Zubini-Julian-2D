using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Biblio
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public long DNI { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public virtual string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"DNI: {dni}");
            retornoFuncion.AppendLine($"NOMBRE: {nombre}");
            return retornoFuncion.ToString();
        }


    }
}
