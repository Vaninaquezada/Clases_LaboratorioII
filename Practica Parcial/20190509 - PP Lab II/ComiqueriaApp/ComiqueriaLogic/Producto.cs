using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private int stock;
        private double precio;
        private string descripcion;

        #region Propiedades
        public string Descripcion
        {
            get { return this.descripcion; }
            
        }

        public double Precio
        {
            get { return this.precio; }
            
        }

        public int Stock
        {
            get { return this.stock; }
            set {
                    if (value >= 0)
                    {
                        this.stock = value;
                    }
                }
        }
        
        #endregion

        //snipp
        #region Constructor Ctor para generar constructor
        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();

        }

        #endregion
        #region metodos
        public static explicit  operator Guid(Producto p)
        {
            return p.codigo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Descripcion: ");
            sb.AppendLine(this.descripcion);

            sb.Append("Codigo: ");
            sb.AppendLine(this.codigo.ToString());

            sb.Append("Precio: ");
            sb.AppendLine(this.precio.ToString());

            sb.Append("Stock: ");
            sb.AppendLine(this.stock.ToString());

            return sb.ToString();
        }

        #endregion

    }
}
