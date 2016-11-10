using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class InvalidDniException : Exception
    {
        private string MensajeBase = "Error";

        public InvalidDniException()
        {
            Console.WriteLine(MensajeBase);
        }

        public InvalidDniException(Exception e):base(e.Message,e)
        {

        }

        public InvalidDniException(String message):base(message)
        {

        }

        public InvalidDniException(String messaje, Exception e):base(messaje,e)
        {

        }
    }
}
