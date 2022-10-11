using System;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Sancor", 2000);
            int respuestaUsuario;
            decimal montoADepositar;
            decimal montoARetirar;
            do
            {
                Console.WriteLine("Bienvenido al sistema, elija una de las siguientes opciones");
                Console.WriteLine("1-Mostrar cuenta");
                Console.WriteLine("2-Deposito");
                Console.WriteLine("3-Retirar");
                Console.WriteLine("4-Salir");
                respuestaUsuario = Int32.Parse(Console.ReadLine());
                switch (respuestaUsuario)
                {
                    case 1:
                        Console.WriteLine($"{c1.mostrar()}"); 
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto que desea depositar: ");
                        montoADepositar = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"{c1.ingresar(montoADepositar)}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto que desea retirar: ");
                        montoARetirar = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"{c1.retirar(montoARetirar)}");
                        break;
                    case 4:
                        Console.WriteLine("Fin del programa");
                        break;
                }
            } while (respuestaUsuario != 4);
        }
    }
}
