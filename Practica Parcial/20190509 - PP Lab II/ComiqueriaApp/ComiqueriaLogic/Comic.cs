using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {

        #region Enum
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion,int stock,double precio,string autor,TipoComic tipoComic):base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        #region metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Autor: ");
            sb.AppendLine(this.autor);

            sb.Append("Tipo Comic: ");
            sb.AppendLine(this.tipoComic.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
