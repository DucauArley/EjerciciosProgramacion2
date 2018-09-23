using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short ruedas, short puertas, Colores color, short cilindrada):base(ruedas, puertas, color)
        {
            this.cilindrada = cilindrada;
        }




    }
}
