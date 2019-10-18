using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Entidades
{
 public class CentralitaException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;

    public string NombreMetodo
    {
      get { return this.nombreMetodo; }
    }


    public string NombreClase
    {
      get { return this.nombreClase; }
    }


    public CentralitaException(string mensaje,string clase,string metodo):this(mensaje,clase,metodo,null)
    {

    }
    public CentralitaException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje,innerException)
    {
      this.nombreMetodo = metodo;
      this.nombreClase = clase;
    }

  }
}
