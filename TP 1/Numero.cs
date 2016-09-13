using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Numero
    {
        private double _Nro;

        public Numero():this(0)
        { 
        
        }

        public Numero(double nro)
        {
            this._Nro = nro;
        }

        public Numero(string nro):this(double.Parse(nro))
        {
         
        }

        private static double validarNumeros(string numeroString)
        {
            bool ParseOk;
            double num;
            
            ParseOk = double.TryParse(numeroString, out num);

            if (ParseOk == true)
            {
                return num;
            }

            else return 0;
        }

        public void Setter(string numeroString)
        {
           this._Nro = validarNumeros(numeroString);
           //set { this._Nro = value; }
        }

        public double Getter()
        {   
            return this._Nro;
            //get { return this._Nro }
        }
    }
}
