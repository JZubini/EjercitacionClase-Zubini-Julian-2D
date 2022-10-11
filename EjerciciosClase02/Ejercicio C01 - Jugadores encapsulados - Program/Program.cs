using System;
using Ejercicio_C01___Jugadores_encapsulados___Biblioteca;
namespace Ejercicio_C01___Jugadores_encapsulados___Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Equipo EquipoRacing = new Equipo(20, "Racing");
            Jugador J1 = new Jugador(12345678, "Gustavo Bou", 20, 10);
            Jugador J2 = new Jugador(12345678, "Christian Martino", 5, 1);
            Jugador J3 = new Jugador(98765432, "Rodrigo Martinez", 8, 4);

            bool resultado;
            resultado = EquipoRacing + J1;
            resultado = EquipoRacing + J2;
            resultado = EquipoRacing + J3;

            foreach (Jugador item in EquipoRacing.Jugadores)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{item.MostrarDatos()}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
