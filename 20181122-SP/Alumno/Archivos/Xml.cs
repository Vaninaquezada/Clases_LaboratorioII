using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(archivo);
                serializer.Serialize(writer, datos);
                writer.Close();

               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(archivo);
                datos = (T)serializer.Deserialize(reader);
                reader.Close();

                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
