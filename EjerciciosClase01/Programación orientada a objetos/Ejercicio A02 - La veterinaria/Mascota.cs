using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A02___La_veterinaria
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string historialVacunacion;

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento, string historialVacunacion) : this(especie, nombre, fechaDeNacimiento)
        {
            
        }



        public string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"Nombre: {nombre}");
            retornoFuncion.AppendLine($"Especie: {especie}");
            retornoFuncion.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento}");
            if(historialVacunacion != null)
            {
                retornoFuncion.AppendLine($"Historial de vacunación: {historialVacunacion}");
            }
            return retornoFuncion.ToString();
        }


    }
}
