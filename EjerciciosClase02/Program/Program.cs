using System;
using System.Collections.Generic;
using Biblioteca;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* NIVEL 1 */
            /*
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();
            string respuestaUsuario;
            int respuestaUsuarioInt;
            string productoEntregado;

            maquinaExpendedora.Add(1,"Pepsi");
            maquinaExpendedora.Add(2, "Monster");
            maquinaExpendedora.Add(3, "Coca-Cola");
            maquinaExpendedora.Add(4, "Speed");
            maquinaExpendedora.Add(5, "Seven-Up");
            maquinaExpendedora.Add(6, "Sprite");
            maquinaExpendedora.Add(7, "Mirinda");
            maquinaExpendedora.Add(8, "Fanta");
            maquinaExpendedora.Add(9, "Rockstar");
            maquinaExpendedora.Add(10, "Redbull");

            do
            {
                Console.WriteLine("-----------Bebidas disponibles--------------");

                foreach (KeyValuePair<int, string> item in maquinaExpendedora)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine("-----------Ingreso--------------");
                Console.WriteLine("Ingrese el código de la bebida que desea tomar: ");
                respuestaUsuario = Console.ReadLine();
                if (respuestaUsuario != "S")
                {
                    Console.WriteLine("-----------Entrega de producto--------------");
                    Int32.TryParse(respuestaUsuario, out respuestaUsuarioInt);
                    maquinaExpendedora.Remove(respuestaUsuarioInt, out productoEntregado);
                    Console.WriteLine($"Producto entregado: {productoEntregado}");
                }
                Console.WriteLine("--------------------------------------------");
            } while (respuestaUsuario != "S");
            */

            /* NIVEL 2 */
            /*
            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();
            string respuestaUsuario;
            int respuestaUsuarioInt;
            maquinaExpendedora.Add(1, new Producto("Pepsi",70));
            maquinaExpendedora.Add(2, new Producto("Coca-Cola", 80));
            maquinaExpendedora.Add(3, new Producto("Seven-Up", 75.25));
            maquinaExpendedora.Add(4, new Producto("Sprite", 70));
            maquinaExpendedora.Add(5, new Producto("Mirinda", 25));
            maquinaExpendedora.Add(6, new Producto("Fanta", 20));
            maquinaExpendedora.Add(7, new Producto("Monster", 200));
            maquinaExpendedora.Add(8, new Producto("Redbull", 170));
            maquinaExpendedora.Add(9, new Producto("Speed", 150));
            maquinaExpendedora.Add(10, new Producto("Rockstar", 120));

            do
            {
                Console.WriteLine("-----------Bebidas disponibles--------------");

                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine($"\t[{item.Key} - {item.Value.Nombre} - {item.Value.PrecioProducto}]");
                }
                Console.WriteLine("-----------Ingreso--------------");
                Console.WriteLine("Ingrese el código de la bebida que desea tomar: ");
                respuestaUsuario = Console.ReadLine();
                if (respuestaUsuario != "S")
                {
                    Console.WriteLine("-----------Entrega de producto--------------");
                    Int32.TryParse(respuestaUsuario, out respuestaUsuarioInt);
                    Console.WriteLine($"Producto entregado: {maquinaExpendedora[respuestaUsuarioInt].Nombre}");
                    maquinaExpendedora.Remove(respuestaUsuarioInt);
                }
                Console.WriteLine("--------------------------------------------");
            } while (respuestaUsuario != "S" && maquinaExpendedora.Count != 0);
            if(maquinaExpendedora.Count == 0)
            {
                Console.WriteLine("No hay más productos para comprar");
            }
            */

            /* NIVEL 3 */
            /*
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            int respuestaUsuarioInt;
            Producto auxProducto;
            Stack<Producto> pepsi = new Stack<Producto>();
            Stack<Producto> monster = new Stack<Producto>();
            Stack<Producto> sprite = new Stack<Producto>();
            pepsi.Push(new Producto(051, "Pepsi", 70));
            monster.Push(new Producto(052, "Monster", 230));
            sprite.Push(new Producto(053, "Sprite", 100));
            maquinaExpendedora.Add(1, pepsi);
            maquinaExpendedora.Add(2, monster);
            maquinaExpendedora.Add(3, sprite);
            do
            {
                Console.WriteLine("-----------Bebidas disponibles--------------");
                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    Console.WriteLine($"POSICION: {item.Key} | NOMBRE: {item.Value.Peek().Nombre} | CANTIDAD: {item.Value.Count}");
                }
                Console.WriteLine("-----------Ingreso--------------");
                Console.WriteLine("Ingrese el código de la bebida que desea saber la información: ");
                respuestaUsuarioInt = Int32.Parse(Console.ReadLine());
                auxProducto = maquinaExpendedora[respuestaUsuarioInt].Pop();
                maquinaExpendedora.Remove(respuestaUsuarioInt);
                Console.WriteLine("-----------Información del producto--------------");
                Console.WriteLine($"CODIGO: {auxProducto.CodigoProducto} | NOMBRE: {auxProducto.Nombre} | PRECIO: {auxProducto.PrecioProducto}");
            } while (maquinaExpendedora.Count != 0);
            */


            /* NIVEL 3 */
            /*
            Queue<string> filaDeClientes = new Queue<string>();
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();
            Stack<Producto> pepsi = new Stack<Producto>();
            Stack<Producto> monster = new Stack<Producto>();
            Stack<Producto> sprite = new Stack<Producto>();
            List<int> productosSinStock = new List<int>();
            Producto auxProducto;
            int respuestaUsuarioInt;
            string respuestaUsuarioString;
            string nuevoCliente;
            filaDeClientes.Enqueue("Julian");
            filaDeClientes.Enqueue("Pedro");
            filaDeClientes.Enqueue("Rodrigo");
            filaDeClientes.Enqueue("Daniel");
            filaDeClientes.Enqueue("Carlos");
            pepsi.Push(new Producto(051, "Pepsi", 70));
            pepsi.Push(new Producto(051, "Pepsi", 70));
            monster.Push(new Producto(052, "Monster", 230));
            monster.Push(new Producto(052, "Monster", 230));
            sprite.Push(new Producto(053, "Sprite", 100));
            sprite.Push(new Producto(053, "Sprite", 100));
            monster.Push(new Producto(052, "Monster", 230));
            sprite.Push(new Producto(053, "Sprite", 100));
            sprite.Push(new Producto(053, "Sprite", 100));
            maquinaExpendedora.Add(1, pepsi);
            maquinaExpendedora.Add(2, monster);
            maquinaExpendedora.Add(3, sprite);
            do
            {
                Console.WriteLine($"CLIENTE ACTUAL: {filaDeClientes.Peek()}");
                Console.WriteLine($"CLIENTES EN COLA: {filaDeClientes.Count}");
                Console.WriteLine("-----------Bebidas disponibles--------------");
                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine($"POSICION: {item.Key} | NOMBRE: {item.Value.Peek().Nombre} | CANTIDAD: {item.Value.Count}");
                    }
                    else
                    {
                        productosSinStock.Add(item.Key);
                    }
                }
                Console.WriteLine("-----------Ingreso--------------");
                Console.WriteLine("Ingrese el código de la bebida que desea tomar: ");
                respuestaUsuarioInt = Int32.Parse(Console.ReadLine());
                while (Validador.validarKeyVacia(productosSinStock, respuestaUsuarioInt))
                {
                    Console.WriteLine("ERROR, el producto seleccionado no tiene stock, reingrese a continuacion: ");
                    Console.WriteLine("Ingrese el código de la bebida que desea tomar: ");
                    respuestaUsuarioInt = Int32.Parse(Console.ReadLine());
                }
                auxProducto = maquinaExpendedora[respuestaUsuarioInt].Pop();     
                Console.WriteLine("-----------FACTURA--------------");
                Console.WriteLine($"CLIENTE: {filaDeClientes.Peek()} | PRODUCTO: {auxProducto.Nombre} | PRECIO: ${auxProducto.PrecioProducto}");
                filaDeClientes.Dequeue();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¡Siguiente!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                if(filaDeClientes.Count == 0)
                {
                    Console.WriteLine("Cola de clientes vacía.");
                    Console.WriteLine("¿Desea agregar mas clientes a la cola? S/N");
                    respuestaUsuarioString = Console.ReadLine();
                    while(respuestaUsuarioString != "S" && respuestaUsuarioString != "N" && respuestaUsuarioString != "s" && respuestaUsuarioString != "n")
                    {
                        Console.WriteLine("ERROR, el valor ingresado es incorrecto. Recuerde ingresar S si quiere agregar mas usuarios a la lista o N si no desea agregar mas.");
                        Console.WriteLine("¿Desea agregar mas clientes a la cola? S/N");
                        respuestaUsuarioString = Console.ReadLine();
                    }
                    do
                    {
                        Console.WriteLine("Por favor, ingrese el nombre del nuevo cliente: ");
                        nuevoCliente = Console.ReadLine();
                        filaDeClientes.Enqueue(nuevoCliente);
                        Console.WriteLine("¿Desea agregar otro cliente? S/N");
                        respuestaUsuarioString = Console.ReadLine();
                    } while (respuestaUsuarioString == "S" && respuestaUsuarioString == "s");
                    Console.Clear();
                }
            } while (filaDeClientes.Count != 0);
            */

            /* NIVEL 4 */
            /*
            List<Producto> mesaBuffet = new List<Producto>();
            List<Producto> ordenCliente = new List<Producto>();
            Queue<string> filaDeClientes = new Queue<string>();
            int respuestaUsuarioInt;
            double montoFinal;
            string respuestaUsuarioString;
            montoFinal = 0;
            mesaBuffet.Add(new Producto(01, "Pepsi", 100));
            mesaBuffet.Add(new Producto(02, "Agua", 70));
            mesaBuffet.Add(new Producto(03, "Milanesa", 230));
            mesaBuffet.Add(new Producto(04, "Ravioles", 200));
            mesaBuffet.Add(new Producto(05, "Pizza", 540));
            filaDeClientes.Enqueue("Julian");
            filaDeClientes.Enqueue("Pedro");
            filaDeClientes.Enqueue("Rodrigo");
            filaDeClientes.Enqueue("Daniel");
            filaDeClientes.Enqueue("Carlos");

            while (filaDeClientes.Count != 0) 
            {
                Console.WriteLine($"CLIENTE ACTUAL: {filaDeClientes.Peek()}");
                Console.WriteLine($"CLIENTES EN COLA: {filaDeClientes.Count}");
                Console.WriteLine("-----------Buffet--------------");
                foreach(Producto item in mesaBuffet)
                {
                    Console.WriteLine($"{mesaBuffet.IndexOf(item)} | PRODUCTO: {item.Nombre} | PRECIO: ${item.PrecioProducto}");
                }
                Console.WriteLine("-----------Ingreso--------------");
                Console.WriteLine("Ingrese el código del producto que desea: ");
                respuestaUsuarioInt = Int32.Parse(Console.ReadLine());
                montoFinal += mesaBuffet[respuestaUsuarioInt].PrecioProducto;
                ordenCliente.Add(mesaBuffet[respuestaUsuarioInt]);
                Console.WriteLine("¿Desea comprar algo mas? S/N");
                respuestaUsuarioString = Console.ReadLine();
                while (respuestaUsuarioString == "S" || respuestaUsuarioString == "s")
                {
                    foreach (Producto item in mesaBuffet)
                    {
                        Console.WriteLine($"PRODUCTO: {item.Nombre} | PRECIO: ${item.PrecioProducto}");
                    }
                    Console.WriteLine("Ingrese el código del producto que desea: ");
                    respuestaUsuarioInt = Int32.Parse(Console.ReadLine());
                    montoFinal += mesaBuffet[respuestaUsuarioInt].PrecioProducto;
                    ordenCliente.Add(mesaBuffet[respuestaUsuarioInt]);
                    Console.WriteLine("¿Desea comprar algo mas? S/N");
                    respuestaUsuarioString = Console.ReadLine();
                }
                Console.WriteLine("-----------FACTURA--------------");
                foreach (Producto item in ordenCliente)
                {
                    Console.WriteLine($"CLIENTE: {filaDeClientes.Peek()} | PRODUCTO: {item.Nombre} | PRECIO: ${item.PrecioProducto}");
                }
                Console.WriteLine($"MONTO FINAL: {montoFinal}");
                filaDeClientes.Dequeue();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¡Siguiente!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            
            }
            */
        }
    }
}
