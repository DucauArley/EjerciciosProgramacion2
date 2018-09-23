using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Camion:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;
        
        public Camion(short ruedas, short puertas, Colores color, short marchas, int peso):base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = peso;
        }



    }
}
