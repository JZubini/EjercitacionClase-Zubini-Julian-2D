using System;
using Biblioteca;
namespace Ejercicio_I02___Desea_continuar
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sumatoriaDeNumeros;
            string respuestaUsuario;
            sumatoriaDeNumeros = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                sumatoriaDeNumeros += Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿Desea seguir ingresando numeros? S/N");
                respuestaUsuario = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuestaUsuario));
            Console.WriteLine($"Sumatoria: {sumatoriaDeNumeros}");
        }
    }
}
