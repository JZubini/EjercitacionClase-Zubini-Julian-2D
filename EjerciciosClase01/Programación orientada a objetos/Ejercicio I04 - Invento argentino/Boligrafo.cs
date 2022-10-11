using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04___Invento_argentino
{
    public class Boligrafo
    {
        static short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
            cantidadTintaMaxima = 100;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaResultante;
            tintaResultante = (short)(GetTinta() + tinta);
            if(tintaResultante >= 0 && tintaResultante <= cantidadTintaMaxima)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - GetTinta()));
        }

        public bool Pintar(short gasto,out string dibujo)
        {
            StringBuilder retornoDibujo = new StringBuilder();
            for(short i = 0; i < gasto; i++)
            {
                if(GetTinta() > 0)
                {
                    retornoDibujo.Append("*");
                    SetTinta(-1);
                }
            }
            dibujo = retornoDibujo.ToString();
            return true;
        }
    }
}


