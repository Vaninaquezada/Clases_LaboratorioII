using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {

        private double altura;

        #region Constructores
        public Figura( int stock, double precio, double altura) : this(string.Format("Figura {0:0.00} cm",altura), stock, precio,altura)
        {
            
        }
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        #endregion

        #region metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Altura: ");
            sb.Append(this.altura.ToString());
            
            return sb.ToString();
        }

        #endregion

    }
}
