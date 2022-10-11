using System.Text;

namespace Central
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada { get { return CalcularCosto(); } }


        private float CalcularCosto()
        {
            return Duracion * costo;
        }

        public override string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine(base.Mostrar());
            retornoFuncion.AppendLine($"COSTO: ${CostoLlamada}");
            return retornoFuncion.ToString();
        }
    }
}
