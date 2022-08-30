using System;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona("Julián",new DateTime(2010,5,25),41991614);
            Persona P2 = new Persona("Juan", new DateTime(1991, 1, 1), 38951258);
            Persona P3 = new Persona("Guido", new DateTime(1993, 3, 22), 39582465);
            Console.WriteLine($"{P1.Nombre} {P1.EsMayorDeEdad()}");
            Console.WriteLine($"{P2.Nombre} {P2.EsMayorDeEdad()}");
            Console.WriteLine($"{P3.Nombre} {P3.EsMayorDeEdad()}");
        }
    }
}
