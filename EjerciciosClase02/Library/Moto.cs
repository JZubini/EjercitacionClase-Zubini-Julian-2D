using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada,short cantidadMarchas,short cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas,color, cantidadPasajeros, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }


    }
}
