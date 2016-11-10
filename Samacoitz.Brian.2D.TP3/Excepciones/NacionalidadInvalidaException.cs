using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
        { 
            Console.WriteLine("La nacionalidad no coincide con el documento");
        }

        public NacionalidadInvalidaException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
