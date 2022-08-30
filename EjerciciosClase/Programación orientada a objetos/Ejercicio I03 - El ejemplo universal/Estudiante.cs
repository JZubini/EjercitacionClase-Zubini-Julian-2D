using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03___El_ejemplo_universal
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        private Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre) : this()
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6,10);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"Nombre: {nombre}");
            retornoFuncion.AppendLine($"Apellido: {apellido}");
            retornoFuncion.AppendLine($"Legajo: {legajo}");
            retornoFuncion.AppendLine($"Nota 1er parcial: {notaPrimerParcial}");
            retornoFuncion.AppendLine($"Nota 2do parcial: {notaSegundoParcial}");
            retornoFuncion.AppendLine($"Promedio: {CalcularPromedio()}");
            if(CalcularNotaFinal() != -1)
            {
                retornoFuncion.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else
            {
                retornoFuncion.AppendLine("Alumno desaprobado");
            }
            return retornoFuncion.ToString();
        }

    }
}
