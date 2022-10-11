using System;
using Biblio;
namespace Ejercicio_C01___Herencia_deportiva___Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Equipo EquipoRacing = new Equipo(20, "Racing");
            Persona P1 = new DirectorTecnico("Gustavo Bou", new DateTime(1999,05,25));
            Jugador P2 = new Jugador(12345678, "Christian Martino", 5, 1);
            Jugador P3 = new Jugador(98765432, "Rodrigo Martinez", 8, 4);

            bool resultado;
            resultado = EquipoRacing + P1;
            resultado = EquipoRacing + P2;
            resultado = EquipoRacing + P3;

            foreach (Persona item in EquipoRacing.Integrantes)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"{item.MostrarDatos()}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}
