using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        protected List<Alumno> _alumnos;
        protected Gimnasio.EClases _clases;
        protected Instructor _instructor;

        //public Jornada this[int i]
        //{
        //    get { return 
        //}

        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        public Jornada(Gimnasio.EClases clase, Instructor instructor):this()
        {
            this._clases = clase;
            this._instructor = instructor;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool esta = false;

            if (a == j._clases)
            {
                esta = true;
                return esta;
            }

            return esta;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {

            if (!Object.ReferenceEquals(j, null) && !Object.ReferenceEquals(a, null))
            {
                if (j == a)
                {
                    j._alumnos.Add(a);
                }
            }

            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nJORNADA\n");
            sb.AppendFormat("Clase de: {0} dada por {1}", this._clases.ToString(), this._instructor.ToString());
            sb.AppendLine("\n\nAlumnos");

            foreach (Alumno elemento in this._alumnos)
            {
                sb.AppendFormat(elemento.ToString());
            }

            return sb.ToString();
        }
    }
}
