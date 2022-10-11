using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder retornoFuncion = new StringBuilder();
            int resto;
            int divisor;
            int cociente;
            resto = numeroEntero % 2;
            cociente = numeroEntero / 2;
            while(cociente > 2);
            {
                cociente = cociente / 2;
                resto = numeroEntero % 2;
            } 
            
        }
    }
}
