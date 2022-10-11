using System;
using System.Collections.Generic;
using Biblioteca;
namespace La_máquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /* NIVEL 1: Dictionary
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();
            maquinaExpendedora.Add(01,"Coca-cola");
            maquinaExpendedora.Add(02, "Pepsi");
            maquinaExpendedora.Add(03, "Sprite");
            maquinaExpendedora.Add(04, "Paso de los toros");
            maquinaExpendedora.Add(05, "Seven-Up");
            maquinaExpendedora.Add(06, "Manaos");
            maquinaExpendedora.Add(07, "Monster");
            maquinaExpendedora.Add(08, "Speed");
            maquinaExpendedora.Add(09, "Redbull");
            maquinaExpendedora.Add(10, "Rockstar");
            */

            /* NIVEL 2: Dictionary con clase Producto.
            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();
            maquinaExpendedora.Add(01, new Producto("Coca-Cola",100));
            maquinaExpendedora.Add(02, new Producto("Pepsi", 150));
            maquinaExpendedora.Add(03, new Producto("Sprite", 50));
            maquinaExpendedora.Add(04, new Producto("Paso de los toros", 100));
            maquinaExpendedora.Add(05, new Producto("Seven-Up", 50));
            maquinaExpendedora.Add(06, new Producto("Manaos", 1000));
            maquinaExpendedora.Add(07, new Producto("Monster", 250));
            maquinaExpendedora.Add(08, new Producto("Speed", 180));
            maquinaExpendedora.Add(09, new Producto("Redbull", 150));
            maquinaExpendedora.Add(10, new Producto("Rockstar", 10));

            /*

            do
            {
                Console.WriteLine("---------------------------------------------");
                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine($"[{item.Key}, {item.Value.Nombre} , ${item.Value.PrecioDelProducto} ]");
                }
                Console.WriteLine("Ingrese el codigo del producto que desea");
                respuestaUsuario = Console.ReadLine();
                if (respuestaUsuario != "S")
                {
                    respuestaUsuarioInt = Int32.Parse(respuestaUsuario);
                    while (respuestaUsuarioInt > 10 || respuestaUsuarioInt < 1)
                    {
                        Console.WriteLine("ERROR, el codigo ingresado es incorrecto, vuelva a ingresar:");
                        respuestaUsuario = Console.ReadLine();
                        respuestaUsuarioInt = Int32.Parse(respuestaUsuario);
                    }
                    Console.WriteLine($"{maquinaExpendedora[respuestaUsuarioInt].Nombre} entregada!");
                    maquinaExpendedora.Remove(respuestaUsuarioInt);
                    Console.WriteLine("---------------------------------------------");
                }
            } while (respuestaUsuario != "S");

            Console.WriteLine("Programa cerrado");
            */


           
        }
    }
}
