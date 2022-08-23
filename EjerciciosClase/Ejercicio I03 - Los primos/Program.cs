using System;

namespace Ejercicio_I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numeroIngresadoString;
            int numeroIngresadoInt;
            bool esNumero;
            string respuestaUsuario;
            int contadorDivisores;
            contadorDivisores = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresadoString = Console.ReadLine();
                esNumero = int.TryParse(numeroIngresadoString, out numeroIngresadoInt);
                while (esNumero == false && numeroIngresadoString != "salir")
                {
                    Console.WriteLine("ERROR. Reingrese un numero: ");
                    numeroIngresadoString = Console.ReadLine();
                }
                Console.WriteLine("--------------Numeros primos--------------");
                for (int i = 2; i < numeroIngresadoInt; i++)
                {
                    for (int x = 1; x < numeroIngresadoInt; x++)
                    {
                        if (contadorDivisores > 2)
                        {
                            break;
                        }
                        else
                        {
                            if (i % x == 0)
                            {
                                contadorDivisores++;
                            }
                        }
                    }
                    if (contadorDivisores == 2)
                    {
                        Console.WriteLine(i);
                    }
                    contadorDivisores = 0;
                }
                Console.WriteLine("¿Desea seguir operando? s/n");
                respuestaUsuario = Console.ReadLine();
            } while (respuestaUsuario == "s");
        }
    }
}
