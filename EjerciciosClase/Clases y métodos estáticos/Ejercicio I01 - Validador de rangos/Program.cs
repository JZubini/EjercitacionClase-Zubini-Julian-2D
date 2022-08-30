using System;
using Biblioteca;
namespace Ejercicio_I01___Validador_de_rangos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMayor;
            int numeroMenor;
            int sumatoriaDeNumerosIngresados;
            int promedio;
            bool esPrimerIngreso;
            esPrimerIngreso = true;
            sumatoriaDeNumerosIngresados = 0;
            numeroMayor = 0;
            numeroMenor = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Int32.Parse(Console.ReadLine());
                while (!(Validador.Validar(numeroIngresado, -100, 100)))
                {
                    Console.WriteLine("ERROR, el numero ingresado esta fuera del rango, reingrese: ");
                    numeroIngresado = Int32.Parse(Console.ReadLine());
                }
                sumatoriaDeNumerosIngresados += numeroIngresado;
                if (esPrimerIngreso)
                {
                    numeroMayor = numeroIngresado;
                    numeroMenor = numeroIngresado;
                    esPrimerIngreso = false;
                }
                else
                {
                    if (numeroIngresado > numeroMayor)
                    {
                        numeroMayor = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMenor)
                    {
                        numeroMenor = numeroIngresado;
                    }
                }

            }
            promedio = sumatoriaDeNumerosIngresados / 10;
            Console.WriteLine($"Numero mayor ingresado: {numeroMayor}");
            Console.WriteLine($"Numero menor ingresado: {numeroMenor}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}
