using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color = new ConsoleColor();
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            ConsoleColor colorear;

            colorear = this.color;

            return colorear;
        }

        public short GetTinta()
        {
            short cantidad;

            cantidad = this.tinta;

            return cantidad;
        }

        private void SetTinta(short tinta)
        {
            if(tinta <= 100 && tinta >= 0)
            {
                this.tinta = tinta;
            }
            else
            {
                if(tinta <= 0)
                {
                    this.tinta = 0;
                }
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool ok = false;
            dibujo = "";
            int tintaNueva;
            short tintaNeta = 0;

            for (int i = 0; i < gasto; i++)
            {
                if (i < GetTinta())
                {
                    dibujo += '*';
                    ok = true;
                }
            }

           
            tintaNueva = GetTinta() - gasto;

            tintaNeta = (short)tintaNueva;

            SetTinta(tintaNeta);

            if(GetTinta() == 0)
            {
                Recargar();
            }

            return ok;
        }
        
    }
}
