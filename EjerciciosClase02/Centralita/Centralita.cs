using System.Collections.Generic;
using System.Text;

namespace Central
{
    public class Centralita
    {
        private List<Llamada> listaDeLllamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLllamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public List<Llamada> Llamadas { get { return listaDeLllamadas; } }
        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumuladorCostoLlamadas;
            acumuladorCostoLlamadas = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada item in listaDeLllamadas)
                    {
                        Local auxLocal;
                        auxLocal = (Local)item;
                        acumuladorCostoLlamadas += auxLocal.CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada item in listaDeLllamadas)
                    {
                        Provincial auxProvincial;
                        auxProvincial = (Provincial)item;
                        acumuladorCostoLlamadas += (float)(auxProvincial.CostoLlamada);
                    }
                    break;
                default:
                    foreach (Llamada item in listaDeLllamadas)
                    {
                        Local auxLocal;
                        auxLocal = (Local)item;
                        acumuladorCostoLlamadas += auxLocal.CostoLlamada;
                    }
                    foreach (Llamada item in listaDeLllamadas)
                    {
                        Provincial auxProvincial;
                        auxProvincial = (Provincial)item;
                        acumuladorCostoLlamadas += (float)(auxProvincial.CostoLlamada);
                    }
                    break;
            }
            return acumuladorCostoLlamadas;
        }

        public virtual string Mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"RAZÓN SOCIAL: {razonSocial}");
            retornoFuncion.AppendLine("LISTA DE LLAMADAS:");
            foreach (Llamada item in listaDeLllamadas)
            {
                retornoFuncion.AppendLine($"{item.Mostrar()}");
            }
            return retornoFuncion.ToString();
        }

        public void OrdenarLlamadas()
        {
            bool modificaciones;
            Llamada auxLlamada;
            do
            {
                modificaciones = false;
                for (int i = 0; i < listaDeLllamadas.Count; i++)
                {
                    for (int x = 0; x < listaDeLllamadas.Count; x++)
                    {
                        if (listaDeLllamadas[i].Duracion < listaDeLllamadas[x].Duracion)
                        {
                            auxLlamada = listaDeLllamadas[i];
                            listaDeLllamadas[i] = listaDeLllamadas[x];
                            listaDeLllamadas[x] = auxLlamada;
                            modificaciones = true;
                        } 
                    }
                }
            } while (modificaciones);
            
        }
    }
}
