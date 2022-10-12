using System;

namespace Library
{
    public enum Colores { Rojo,Blanco,Azul,Gris,Negro}


    public class Automovil : VehiculoTerrestre
    {

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadPasajeros, cantidadMarchas) {}

    }
}
