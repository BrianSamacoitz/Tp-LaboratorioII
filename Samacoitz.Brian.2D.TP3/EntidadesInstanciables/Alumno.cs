using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public class Alumno : PersonaGimnasio
    {
        protected Gimnasio.EClases _claseQueToma;
        protected EEstadoCuenta _estadoCuenta;

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            MesPrueba
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQuetoma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this._claseQueToma = claseQuetoma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta):base(id,nombre,apellido,dni,nacionalidad)
        { 
            this._claseQueToma = claseQueToma;
            this._estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            return base.MostrarDatos() + "\nClase que toma: " + this._claseQueToma.ToString() + "\nEstado Cuenta: " + this._estadoCuenta;
        }

        protected override void ParticiparEnClase()
        {
            Console.WriteLine("Toma clases de: {0}",this._claseQueToma.ToString());
        }
        
        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendFormat("\nNombre completo: {0} {1}", base._nombre,base._apellido);
            SB.AppendFormat("\nNacionalidad : {0}", base._nacionalidad);
            SB.AppendFormat("\nID {0}", base._identificador);
            SB.AppendFormat("\nEstado de cuenta: {0}", this._estadoCuenta);
            SB.AppendFormat("\nClase que toma: {0}", this._claseQueToma);
            SB.AppendLine("\n");

            return SB.ToString();
        }

        public static bool operator ==(Alumno a, Gimnasio.EClases clase)
        {
            bool esta = false;

            if (a._claseQueToma == clase)
            {
                if (!(a._estadoCuenta == EEstadoCuenta.Deudor))
                {
                    esta = true;
                }
            }
            return esta;
        }

        public static bool operator !=(Alumno a, Gimnasio.EClases clase)
        {
            return !(a == clase);
        }
       
    }
}
