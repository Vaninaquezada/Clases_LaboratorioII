using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Ejercicio_57
{
   public class Persona

        
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

        }

        public static bool Guardar(Persona persona)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("/archivo.txt", System.Text.Encoding.UTF8);

                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                return true;
            }
            catch (Exception e)
            {

                throw e;
               
            }

             return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.nombre);
            sb.AppendFormat("Apellido: {0}", this.apellido);
            return sb.ToString();
        }
    }
}
