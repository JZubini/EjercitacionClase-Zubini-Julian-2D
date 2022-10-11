using System;
using System.Text;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
	public class Persona
	{
		private string nombre;
		private DateTime fechaDeNacimiento;
		private int dni;

		public Persona(string nombre, DateTime fechaDeNacimiento, int DNI)
		{
			this.nombre = nombre;
			this.fechaDeNacimiento = fechaDeNacimiento;
			this.DNI = DNI;
		}

		public string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}

		public DateTime FechaDeNacimiento
		{
			get
			{
				return this.FechaDeNacimiento;
			}
			set
			{
				this.fechaDeNacimiento = value;
			}
		}

		public int DNI
		{
			get
			{
				return this.dni;
			}
			set
			{
				this.dni = value;
			}
		}

		public int CalcularEdad()
		{
			DateTime fechaActual;
			fechaActual = DateTime.Today;
			return fechaActual.Year - fechaDeNacimiento.Year;
		}

		public string Mostrar()
		{
			StringBuilder retornoFuncion = new StringBuilder();
			retornoFuncion.AppendLine($"Nombre: {nombre}");
			retornoFuncion.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento}");
			retornoFuncion.AppendLine($"Edad: {CalcularEdad()}");
			retornoFuncion.AppendLine($"DNI: {dni}");
			return retornoFuncion.ToString();
		}

		public string EsMayorDeEdad()
		{
            if (CalcularEdad() >= 18)
			{
				return "es mayor de edad";
			}
			else
			{
				return "es menor de edad";

			}
		}

	}
}
