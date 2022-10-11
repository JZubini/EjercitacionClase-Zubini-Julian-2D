using System.Text;

namespace Central
{
    public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion < llamada2.Duracion)
            {
                return 1;
            }
            return 0;
        }

        public virtual string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"NRO DESTINO: {nroDestino}");
            retornoFuncion.AppendLine($"NRO ORIGEN: {nroOrigen}");
            retornoFuncion.AppendLine($"DURACION: {duracion}");
            return retornoFuncion.ToString();
        }

    }
}
