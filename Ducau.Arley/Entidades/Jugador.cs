using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;



        /// <summary>
        /// Constructor de jugador, llama al constructor de persona
        /// </summary>
        /// <param name="nombre"></param>Nombre del jugador
        /// <param name="apellido"></param>Apellido del jugador
        /// <param name="edad"></param>Edad del jugador
        /// <param name="dni"></param>Dni del jugador
        /// <param name="peso"></param>Peso del jugador
        /// <param name="altura"></param>Altura del jugador
        /// <param name="posicion"></param>Posicion del jugador
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion):base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }



        /// <summary>
        /// Propiedad de solo lectura de la altura
        /// </summary>
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de el peso
        /// </summary>
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de la posicion
        /// </summary>
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }



        /// <summary>
        /// Muestra los datos del jugador
        /// </summary>
        /// <returns></returns>Devuelve una cadena con los datos del jugador 
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.Mostrar());
            str.AppendLine("Altura: " + Altura);
            str.AppendLine("Peso: " + Peso);
            str.AppendLine("Posicion: " + Posicion);

            retorno = str.ToString();

            return retorno;
        }


        /// <summary>
        /// Valida que el jugador este en buen estado fisico con la variable imc que debe estar entre 18.5 y25
        /// </summary>
        /// <returns></returns>true si lo esta, false si no
        public bool ValidarEstadoFisico()
        {
            bool ok = false;
            double imc;

            imc = this.Peso / Math.Pow(this.Altura, 2);

            if(imc >= 18.5F && imc <= 25)
            {
                ok = true;
            }

            return ok;
        }


        /// <summary>
        /// Valida si el jugador es apto, si cumple con la edad y si esta en buen estado fisico
        /// </summary>
        /// <returns></returns>true si es apto y false si no lo es
        public override bool ValidarAptitud()
        {
            bool ok = false;

            if (this.Edad < 40 && this.Edad > 0)
            {
                if (ValidarEstadoFisico())
                {
                    ok = true;
                }
            }

            return ok;
        }



    }
}
