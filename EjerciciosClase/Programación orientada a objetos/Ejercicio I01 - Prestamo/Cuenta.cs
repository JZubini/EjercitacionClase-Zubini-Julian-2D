using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    public class Cuenta
    {
        string titular;
        decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get
            {
                return this.titular;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public string mostrar()
        {
            StringBuilder retornoFuncion = new StringBuilder();
            retornoFuncion.AppendLine($"Titular: {titular}");
            retornoFuncion.AppendLine($"Cantidad: {cantidad}");
            return retornoFuncion.ToString();
        }

        public string ingresar(decimal monto)
        {
            if(monto > 0)
            {
                cantidad += monto;
                return $"Operacion exitosa. Su nuevo saldo es {cantidad}";
            }
            return "ERROR, el monto ingresado es negativo.";
        }

        public string retirar(decimal monto)
        {
            cantidad -= monto;
            return $"Operacion exitosa. Su nuevo saldo es {cantidad}";
        }
    }
}
