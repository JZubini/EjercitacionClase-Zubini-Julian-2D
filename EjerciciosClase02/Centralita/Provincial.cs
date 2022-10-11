using System.Text;

namespace Central
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja franjaHoraria;

        public Provincial(Franja franjaHoraria, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public double CostoLlamada { get { return CalcularCosto(); } }

        private double CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    return Duracion * 0.99;
                case Franja.Franja_2:
                    return Duracion * 1.25;
                default:
                    return Duracion * 0.66;
            }
        }

        public override string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine(base.Mostrar());
            retornoFuncion.AppendLine($"FRANJA: {franjaHoraria}");
            retornoFuncion.AppendLine($"COSTO: ${CostoLlamada}");
            return retornoFuncion.ToString();
        }

    }
}
