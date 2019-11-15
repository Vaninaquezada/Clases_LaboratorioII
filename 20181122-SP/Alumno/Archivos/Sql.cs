using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            throw new NotImplementedException();
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            throw new NotImplementedException();
        }
    }
}
