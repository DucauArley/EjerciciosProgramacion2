using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        private int añosExperiencia;


        /// <summary>
        /// Constructor de director, llama al constructor de persona
        /// </summary>
        /// <param name="nombre"></param>Nombre del director
        /// <param name="apellido"></param>Apellido del director
        /// <param name="edad"></param>Edad del director
        /// <param name="dni"></param>Dni del director
        /// <param name="añosExperiencia"></param>Años de experiencia del director
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }


        /// <summary>
        /// Propiedad de lectura/escritura sobre los años de experiencia
        /// </summary>
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }

            set
            {
                if (value >= 0)
                {
                    this.añosExperiencia = value;
                }
            }
        }

        /// <summary>
        /// Muestra los datos del director
        /// </summary>
        /// <returns></returns>Devuelve una cadena con los datos del director
        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string retorno;

            str.Append(base.Mostrar());
            str.AppendLine("Años de experiencia: " + AñosExperiencia);

            retorno = str.ToString();
            
            return retorno;
        }

        /// <summary>
        /// Valida si el dt es apto, si cumple con la edad y los años de experiencia
        /// </summary>
        /// <returns></returns>true si es apto y false si no lo es
        public override bool ValidarAptitud()
        {
            bool ok = false;

            if(this.Edad < 65 && this.Edad > 0)
            {
                if(this.añosExperiencia >= 2)
                {
                    ok = true;
                }
            }

            return ok;
        }
        
    }
}
