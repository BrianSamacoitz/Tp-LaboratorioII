using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntidadesAbstractas
{
    public abstract class PersonaGimnasio : Persona
    {
        protected int _identificador;

        public PersonaGimnasio(int Id, String Nombre, string Apellido,string Dni, ENacionalidad Nacionalidad):base(Nombre,Apellido,Dni,Nacionalidad)
        {
            this._identificador = Id;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendFormat("Nombre: {0}", base._nombre);
            SB.AppendFormat("Apellido: {0}", base._apellido);
            SB.AppendFormat("Nacionalidad: {0}", base._nacionalidad);
            SB.AppendFormat("ID: {0}", this._identificador);

            return SB.ToString();
        }

        protected abstract void ParticiparEnClase();
        
    }
}
