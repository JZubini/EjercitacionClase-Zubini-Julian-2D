using System;
using Library;
namespace Ejercicio_I01___Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre V1 = new Moto(2, 0, Colores.Rojo, 400, 4, 1);
            VehiculoTerrestre V2 = new Automovil(4, 5, Colores.Gris, 5, 4);
            VehiculoTerrestre V3 = new Camion(8, 2, Colores.Blanco, 6, 400, 3);


            Console.WriteLine("----------------------------");
            Console.WriteLine($"{V1.MostrarDatos()}"); 
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{V2.MostrarDatos()}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"{V3.MostrarDatos()}");
            Console.WriteLine("----------------------------");
        }
    }
}
