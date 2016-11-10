using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    class Text : IArchivo<string>
    {

        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter guardar = new StreamWriter(archivo, true))
                {
                    guardar.WriteLine(datos);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

        }

        public bool Leer(string archivo,string datos)
        {
            try
            {
                using (StreamReader leer = new StreamReader(archivo))
                {
                    datos = leer.ReadToEnd();
                }
                return true;
            }
            catch (Exception e)
            {
                datos = "";
                throw new ArchivosException(e);
            }
        }
    }
}

