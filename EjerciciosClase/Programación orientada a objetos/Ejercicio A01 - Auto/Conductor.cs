using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01___Vienen_con_sistema_de_auto_navegación
{
    public class Conductor
    {
        private string nombre;
        private int[] kilometrosRecorridos = new int[7];

        public Conductor() { }

        public Conductor(string nombre, int[] kilometrosRecorridos)
        {
            this.nombre = nombre;
            this.kilometrosRecorridos = kilometrosRecorridos;
        }

        public string buscarConductorConMayorKilometraje(Conductor[] listaDeConductores)
        {
            int kilometrajeMasAlto;
            string nombreDelConductorConKilometrajeMasAlto;
            kilometrajeMasAlto = 0;
            nombreDelConductorConKilometrajeMasAlto = null;
            for(int i = 0; i < listaDeConductores.Length; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if(listaDeConductores[i].kilometrosRecorridos[x] > kilometrajeMasAlto)
                    {
                        kilometrajeMasAlto = listaDeConductores[i].kilometrosRecorridos[x];
                        nombreDelConductorConKilometrajeMasAlto = listaDeConductores[i].nombre;
                    }
                }
            }
            return nombreDelConductorConKilometrajeMasAlto;
        }

        public string buscarConductorConMayorKilometrajeDia(Conductor[] listaDeConductores,int dia)
        {
            int kilometrajeMasAlto;
            string nombreDelConductorConKilometrajeMasAlto;
            kilometrajeMasAlto = 0;
            nombreDelConductorConKilometrajeMasAlto = null;
            for (int i = 0; i < listaDeConductores.Length; i++)
            {
                if (listaDeConductores[i].kilometrosRecorridos[dia - 1] > kilometrajeMasAlto)
                {
                    kilometrajeMasAlto = listaDeConductores[i].kilometrosRecorridos[dia - 1];
                    nombreDelConductorConKilometrajeMasAlto = listaDeConductores[i].nombre;
                }
            }
            return nombreDelConductorConKilometrajeMasAlto;
        }
    }
}
