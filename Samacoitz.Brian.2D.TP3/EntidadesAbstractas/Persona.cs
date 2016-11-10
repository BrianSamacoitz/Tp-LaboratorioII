using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        protected string _nombre;
        protected string _apellido;
        protected ENacionalidad _nacionalidad;
        protected int _dni;

        #region Propiedades

        public string Nombre
        {
            get { return ValidarNombreApellido(this._nombre); }
            set { this._nombre = ValidarNombreApellido(value); }
        }

        public string Apellido
        {
            get { return ValidarNombreApellido(this._apellido); }
            set { this._apellido = ValidarNombreApellido(value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        public int Dni
        {
            get { return ValidarDNI(this._nacionalidad,this._dni); }
            set { this._dni = ValidarDNI(this._nacionalidad, value); }
        }

        public string StringToDni
        {
            set { this._dni = ValidarDNI(this._nacionalidad, value); }
        }

        #endregion

        #region Constructores

        

        public Persona(string Nombre, string Apellido, int Dni, ENacionalidad Nacionalidad):this(Nombre,Apellido,Nacionalidad)
        {
            this.Dni = Dni;
        }

        public Persona(string Nombre, string Apellido, string Dni, ENacionalidad Nacionalidad):this(Nombre,Apellido,Nacionalidad)
        {
            this.StringToDni = Dni;
        }

        public Persona(string Nombre, string Apellido, ENacionalidad Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this._nacionalidad = Nacionalidad;
        }

        

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendFormat("Nombre: {0}", this._nombre);
            SB.AppendFormat("\nApellido: {0}", this._apellido);
            SB.AppendFormat("\nNacionalidad : {0}", this._nacionalidad);
            SB.AppendFormat("\nDNI: {0}", this._dni);

            return SB.ToString();
        }

        private int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            
            try
            {
                if (ENacionalidad.Argentino == Nacionalidad)
                {
                    if (dato > 1 && dato < 89999999)
                    {
                        return dato;
                    }
                }
                else if (ENacionalidad.Extranjero == nacionalidad)
                {
                    if (dato > 89999999 && dato < 99999999)
                    {
                        return dato;
                    }

                }
            }
            catch (InvalidDniException e)
            {
                Console.WriteLine(e.Message);
            }

            return dato;

        }

        private int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            int resultado = 0;

            try
            {
                resultado = ValidarDNI(nacionalidad, int.Parse(dato));
            }
            catch (InvalidDniException e)
            {
                Console.WriteLine(e.Message);
            }

            return resultado;
        }

        private string ValidarNombreApellido(string dato)
        {
            if(Regex.IsMatch(dato,"^ [a-zA-Z] $"))
            {
                return dato;
            }

            return dato;
            
        }

        #endregion


    }
}
