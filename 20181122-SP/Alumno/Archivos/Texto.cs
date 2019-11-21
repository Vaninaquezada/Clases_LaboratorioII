using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
                {

                    foreach (Patente item in datos)
                    {
                            file.WriteLine(item);
                    }
                    
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = null;
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(archivo, true))
                {
                    String line;

                    datos = new Queue<Patente>();

                    while ((line = file.ReadLine()) != null)
                    {
                        
                        datos.Enqueue(line.ValidarPatente());
                    }
                }

               
            }
            catch (PatenteInvalidaException)
            {
                //throw new Exception(e.Message);
            }
        }

     
    }
}
