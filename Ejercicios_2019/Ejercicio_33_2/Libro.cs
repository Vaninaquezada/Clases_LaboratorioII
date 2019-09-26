using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33_2
{
   public class Libro
    {
        public List<string> paginas;

        public Libro()
        {

            this.paginas = new List<string>;

        }


        public string this[int i]
        {
          
            get {
                //if indice es mayor que o y menor que el count de la lista retorna la pagina
                if (i >= 0 && this.paginas.Count < i)
                {
                    return paginas[i];
                }
                else
                {
                    return string.Empty;

                }
            }
            set {
                if (i >= 0)
                {
                    if (this.paginas.Count < i) {

                        this.paginas[i] = value;

                    }
                    else {

                        this.paginas.Add(value);
                    }
                }
                else {


                }

                paginas[i] = value; }
        
          
          }

    }
}
