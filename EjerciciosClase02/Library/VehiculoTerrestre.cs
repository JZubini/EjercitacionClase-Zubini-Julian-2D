using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private int cantidadPasajeros;
        private short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, int cantidadPasajeros, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }

        public string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"Cantidad de ruedas: {cantidadRuedas}");
            retornoFuncion.AppendLine($"Cantidad de puertas: {cantidadPuertas}");
            retornoFuncion.AppendLine($"Color: {color}");
            retornoFuncion.AppendLine($"Cantidad de pasajeros: {cantidadPasajeros}");
            retornoFuncion.AppendLine($"Cantidad de marchas: {cantidadMarchas}");
            return retornoFuncion.ToString();
        }

    }
}
