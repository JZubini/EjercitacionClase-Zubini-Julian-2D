using System;
using Biblioteca__Ejercicio_C02___Enciendan_sus_motores_;
namespace Program__Ejercicio_C02___Enciendan_sus_motores_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Competencia CopaPiston = new Competencia(5, 2);
            AutoF1 AF1 = new AutoF1("Mercedes", 01);
            AutoF1 AF2 = new AutoF1("Redbull", 02);
            AutoF1 AF3 = new AutoF1("Monster", 03);
            AutoF1 AF4 = new AutoF1("Mercedes", 01);
            bool resultado;

            resultado = CopaPiston + AF1;
            resultado = CopaPiston + AF2;
            resultado = CopaPiston + AF3;

            Console.WriteLine(CopaPiston.MostrarDatos());
            Console.WriteLine("REMUEVO UN AUTO");
            resultado = CopaPiston - AF1;
            Console.WriteLine(CopaPiston.MostrarDatos());
            Console.WriteLine("VERIFICO SI DOS AUTOS SON IGUALES");
            Console.WriteLine($"{AF1 == AF4}");
        }
    }
}
