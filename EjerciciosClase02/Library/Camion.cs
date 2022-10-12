using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga,short cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadPasajeros, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }
    }
}
