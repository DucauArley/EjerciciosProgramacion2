using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor): this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                string retorno = this.anio + "º" + this.division;
                return retorno;
            }
        }

        public static explicit operator string(Curso c)
        {
            string retorno;
            StringBuilder str = new StringBuilder();

            str.AppendLine("Curso: " + c.AnioDivision);
            str.AppendLine("Profesor: \n" + c.profesor.ExponerDatos());
            
            foreach(Alumno a in c.alumnos)
            {
                str.AppendLine(a.ExponerDatos());
            }

            retorno = str.ToString();

            return retorno;
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool ok = false;

            if(c.AnioDivision == a.AnioDivision)
            {
                ok = true;
            }

            return ok;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }

            return c;
        }


    }
}
