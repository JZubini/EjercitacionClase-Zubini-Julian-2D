using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca__Ejercicio_C02___Enciendan_sus_motores_
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"CANTIDAD COMPETIDORES: {cantidadCompetidores}");
            retornoFuncion.AppendLine($"CANTIDAD VUELTAS: {cantidadVueltas}"); 
            retornoFuncion.AppendLine("LISTA DE COMPETIDORES: ");
            foreach (AutoF1 item in competidores)
            {
                retornoFuncion.AppendLine("---------------------------");
                retornoFuncion.AppendLine(item.MostrarDatos());
                retornoFuncion.AppendLine("---------------------------");
            }
            return retornoFuncion.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if ((c.competidores.Count < c.cantidadCompetidores) && (!(c == a)))
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random rnd = new Random();
                a.CantidadCombustible = (short)rnd.Next(15, 100);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                a.EnCompetencia = false;
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (c.competidores.Contains(a))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            if (!(c == a))
            {
                return true;
            }
            return false;
        }

    }
}
