using Biblio;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{ 
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        public DirectorTecnico(string nombre) : base(nombre){}

        public DirectorTecnico(string nombre,DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"DNI: {DNI}");
            retornoFuncion.AppendLine($"NOMBRE: {Nombre}");
            retornoFuncion.AppendLine($"FECHA DE NACIMIENTO: {fechaNacimiento.Date}");
            return retornoFuncion.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1,DirectorTecnico dt2)
        {
            if ((dt1.fechaNacimiento.Equals(dt2.fechaNacimiento) && dt1.Nombre.Equals(dt2.Nombre)))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (!(dt1 == dt2))
            {
                return true;
            }
            return false;
        }


    }
}
