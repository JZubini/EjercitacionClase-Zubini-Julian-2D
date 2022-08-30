using System;

namespace Ejercicio_I03___El_ejemplo_universal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante E1 = new Estudiante("Escobar", "12345", "Diego");
            Estudiante E2 = new Estudiante("Zubini", "54321", "Julian");
            Estudiante E3 = new Estudiante("Brovelli", "67891", "Gabriel");

            E1.SetNotaPrimerParcial(6);
            E1.SetNotaSegundoParcial(6);

            E2.SetNotaPrimerParcial(8);
            E2.SetNotaSegundoParcial(8);

            E3.SetNotaPrimerParcial(2);
            E3.SetNotaSegundoParcial(2);


            Console.WriteLine("------Listado de alumnos------");
            Console.WriteLine($"{E1.Mostrar()}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{E2.Mostrar()}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{E3.Mostrar()}");
            Console.WriteLine("------------------------------");
        }
    }
}
