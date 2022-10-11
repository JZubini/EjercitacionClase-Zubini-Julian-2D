using System;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo BoligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo BoligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            string dibujo;

            BoligrafoAzul.Pintar(95,out dibujo);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{dibujo}");
            Console.ResetColor();
            Console.WriteLine("--------------------");
            Console.BackgroundColor = ConsoleColor.Blue;
            BoligrafoAzul.Pintar(10, out dibujo);
            Console.ResetColor();
            Console.WriteLine($"{dibujo}");

        }
    }
}
