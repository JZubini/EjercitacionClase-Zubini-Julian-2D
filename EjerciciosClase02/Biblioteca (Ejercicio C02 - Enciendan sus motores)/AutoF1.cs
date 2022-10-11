using System;
using System.Data.Common;
using System.Text;
namespace Biblioteca__Ejercicio_C02___Enciendan_sus_motores_
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
            enCompetencia = false;
        }

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"NUMERO: {numero}");
            retornoFuncion.AppendLine($"¿EN COMPETENCIA?: {enCompetencia}");
            retornoFuncion.AppendLine($"ESCUDERIA: {escuderia}");
            retornoFuncion.AppendLine($"CANTIDAD DE COMBUSTIBLE: {cantidadCombustible}");
            retornoFuncion.AppendLine($"VUELTAS RESTANTES: {vueltasRestantes}");
            return retornoFuncion.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if ((a1.numero.Equals(a2.numero)) && a1.escuderia.Equals(a2.escuderia))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            if (!(a1 == a2))
            {
                return true;
            }
            return false;
        }
    }
}
