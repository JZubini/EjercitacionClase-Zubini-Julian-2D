using System;

namespace Ejercicio_I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = Int32.Parse(Console.ReadLine());
            if (numeroIngresado > 0)
            {
                Console.WriteLine($"{numeroIngresado} al cuadrado es: {Math.Pow(numeroIngresado, 2)}");
                Console.WriteLine($"{numeroIngresado} al cubo es: {Math.Pow(numeroIngresado, 3)}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
