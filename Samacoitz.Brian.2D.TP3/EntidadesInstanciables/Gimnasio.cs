using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;
using Archivos;


namespace EntidadesInstanciables
{    
    public class Gimnasio
    {
        public enum EClases
        {
            Pilates,
            Natacion,
            CrossFit,
            Yoga
        }

        protected List<Alumno> _alumnos;
        protected List<Instructor> _instructores;
        protected List<Jornada> _jornadas;

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Instructor>();
            this._jornadas = new List<Jornada>();
        }

        private static string MostrarDatos(Gimnasio gim)
        {
            string mensaje = "";

            foreach (Jornada elemento in gim._jornadas)
            {
                mensaje += ((Jornada)elemento).ToString();
            }

            return mensaje;
        }

        public override string ToString()
        {
           return Gimnasio.MostrarDatos(this).ToString();
        }

        //public static bool Guardar(Gimnasio gim)
        //{ 
           
        //}

        #region Alumno

        public static bool operator ==(Gimnasio g, Alumno a)
        {
            bool esta = false;

            foreach (Alumno elemento in g._alumnos)
            {
                if (elemento == a)
                {
                    esta = true;
                    return esta;
                }
            }

            return esta;
        }

        public static bool operator !=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (!(g == a))
            {
                g._alumnos.Add(a);
            }
            return g;
        }

        #endregion

        #region Instructor

        public static bool operator ==(Gimnasio g, Instructor i)
        {
            bool esta = false;

            foreach (Instructor elemento in g._instructores)
            {
                if (elemento == i)
                {
                    esta = true;
                    return esta;
                }
            }

            return esta;        
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        { 
            return !(g == i);
        }

        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            if (!(g == i))
            {
                g._instructores.Add(i);
            }
            return g;
        }

        public static Instructor operator ==(Gimnasio g, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(g, null))
            {
                foreach (Instructor elemento in g._instructores)
                {
                    if (elemento == clase)
                    {
                        return elemento;
                    }
                }
            }

            throw new SinInstructorException();
        }

        public static Instructor operator !=(Gimnasio g, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(g, null))
            {
                foreach (Instructor elemento in g._instructores)
                {
                    if (elemento != clase)
                    {
                        return elemento;
                    }
                }
            }

            throw new SinInstructorException();
        }

        #endregion

        #region Gim + Clase

        public static Gimnasio operator +(Gimnasio g, Gimnasio.EClases clases)
        {
            
            Jornada j = new Jornada(clases, g == clases);
            List<Alumno> a = new List<Alumno>();

            try
            {
                for (int i = 0; i < g._alumnos.Count; i++)
                {
                    if (g._alumnos[i] == clases)
                    {
                        j += g._alumnos[i];

                    }
                }

                g._jornadas.Add(j);
            }
            catch (InvalidOperationException) { };

            return g;
        }

        #endregion 



    }
}
