using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Automovil:VehiculoTerrestre
    {
        
        private short catidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short ruedas, short puertas, Colores color, short marchas, int pasajeros):base(ruedas, puertas, color)
        {
            this.catidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }




    }
}
