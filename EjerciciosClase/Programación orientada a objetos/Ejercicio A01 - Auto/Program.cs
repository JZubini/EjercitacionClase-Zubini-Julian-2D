using System;

namespace Ejercicio_A01___Vienen_con_sistema_de_auto_navegación
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conductor con = new Conductor();
            Conductor C1 = new Conductor("Juan Perez",new int[] { 100,30,50,0,0,20,80});
            Conductor C2 = new Conductor("Gonzalo Gomez", new int[] { 200, 1, 1, 1, 1, 1, 1 });
            Conductor C3 = new Conductor("Pedro Moreno", new int[] { 20, 30, 1, 2, 5, 25, 50 });

            Conductor[] listaConductores = new Conductor[3];

            listaConductores[0] = C1;
            listaConductores[1] = C2;
            listaConductores[2] = C3;

            Console.WriteLine($"Conductor con mas kilometros: {con.buscarConductorConMayorKilometraje(listaConductores)}");
            Console.WriteLine($"Conductor con mas kilometros en el dia 3: {con.buscarConductorConMayorKilometrajeDia(listaConductores,3)}");
            Console.WriteLine($"Conductor con mas kilometros en el dia 5: {con.buscarConductorConMayorKilometrajeDia(listaConductores, 5)}");
        }
    }
}
