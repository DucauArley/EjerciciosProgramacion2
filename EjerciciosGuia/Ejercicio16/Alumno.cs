using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno()
        {
            this._notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random numero = new Random();

            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = numero.Next();
            }
        }

        public string Mostrar()
        {
            return "Hola";
        }


    }
}
