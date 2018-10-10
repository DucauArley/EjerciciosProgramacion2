using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Posicion
    {
        Arquero,
        Defensor,
        Central,
        Delantero
    }

    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;


        /// <summary>
        /// Constructor de persona
        /// </summary>
        /// <param name="nombre"></param>Nombre de la persona
        /// <param name="apellido"></param>Apellido de la persona
        /// <param name="edad"></param>Edad de la persona
        /// <param name="dni"></param>DNI de la persona
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad de solo lectura de el apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de el dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de la edad
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Muestra los datos de la persona, metodo virtual
        /// </summary>
        /// <returns></returns>Devuelve una cadena con los datos de la persona
        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.AppendLine("Apellido: " + Apellido);
            str.AppendLine("Nombre: " + Nombre);
            str.AppendLine("Edad: " + Edad);
            str.AppendLine("Dni: " + Dni);

            retorno = str.ToString();

            return retorno;
        }


        /// <summary>
        /// Metodo abstracto para validar
        /// </summary>
        /// <returns></returns>devuelve true o false depende en donde se sobreescriba
        public abstract bool ValidarAptitud();
        
    }
}
