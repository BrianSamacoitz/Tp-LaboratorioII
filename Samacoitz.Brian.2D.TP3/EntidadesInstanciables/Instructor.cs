using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public class Instructor : PersonaGimnasio
    {
        protected Queue<Gimnasio.EClases> _clasesDelDia;
        protected static Random _random;

        static Instructor()
        {
            _random = new Random();
        }

        protected void _randomClases()
        {
            _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0,3));
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad): base(id, nombre, apellido,dni,nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>();

            _randomClases();
            _randomClases();
        }

        protected override string MostrarDatos()
        {
            return this.ToString() + base.MostrarDatos();
        }

        protected override void ParticiparEnClase()
        {
            Console.WriteLine("Clases Del Dia: " + this._clasesDelDia);
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            
            SB.AppendFormat(base._nombre);
            SB.AppendFormat(" {0}",base._apellido);
            SB.AppendFormat("\nID: {0}", base._identificador.ToString());
            SB.AppendFormat("\nNacionalidad: {0}", base._nacionalidad);
            SB.AppendLine("\nClases del dia:");
            foreach (Gimnasio.EClases elemento in this._clasesDelDia)
            {
                SB.AppendFormat("{0}\n", elemento);
            }
            
            //ParticiparEnClase(); No me salio

            return SB.ToString();
        }

        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            bool esta = false;

            if (!Object.ReferenceEquals(i, null))
            {
                foreach (Gimnasio.EClases elemento in i._clasesDelDia)
                {
                    if (elemento == clase)
                    {
                        esta = true;
                        continue;
                    }
                }
            }
            return esta;
        }

        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }

    }
}
