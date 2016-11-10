using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    class Xml<T> : IArchivo<T>
    {

        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlTextWriter guardar = new XmlTextWriter(archivo, System.Text.Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(guardar, datos);
                guardar.Close();
                return true;
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.InnerException);
                Console.ReadLine();
                return false;
            }
        }

        //public bool Leer(string archivo, T datos)
        //{
        //    try
        //    {
        //        using (XmlTextReader leer = new XmlTextReader(archivo))
        //        {
        //            XmlSerializer serializer = new XmlSerializer(typeof(T));

        //            archivo = (T)serializer.Deserialize(leer);
        //            Console.WriteLine(archivo.ToString());
        //            leer.Close();
        //            return true;
        //        }
        //    }
        //    catch (ArchivosException e)
        //    {
        //        Console.WriteLine(e.InnerException);
        //        Console.ReadLine();
        //        return false;
        //    }
        //}


        public bool Leer(string archivo, T datos)
        {
            throw new NotImplementedException();
        }
    }
}
