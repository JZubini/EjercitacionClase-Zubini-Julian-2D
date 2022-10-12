using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private List<string> cursos;
        private string direccion;
        private decimal edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(List<string> cursos, string direccion, decimal edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"NOMBRE: {nombre}");
            retornoFuncion.AppendLine($"DIRECCION: {direccion}");
            retornoFuncion.AppendLine($"EDAD: {edad}");
            retornoFuncion.AppendLine($"GÉNERO: {genero}");
            retornoFuncion.AppendLine($"PAÍS: {pais}");
            if (cursos.Count == 0)
            {
                retornoFuncion.AppendLine("No ha realizado ningún curso");
            }
            else
            {
                retornoFuncion.AppendLine("CURSO/S:");
                foreach (string item in cursos)
                {
                    retornoFuncion.AppendLine(item);
                }
            }
            return retornoFuncion.ToString();
        }
    }
}
