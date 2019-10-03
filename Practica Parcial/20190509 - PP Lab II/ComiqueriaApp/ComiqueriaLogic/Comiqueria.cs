using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public  class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get {

                foreach (var item in this.productos)
                {
                    if ((Guid)item == codigo)
                    {
                        return item;
                    }
                }
                return null;

            }

        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
         public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();

            foreach (var item in this.productos)
            {
                diccionario.Add((Guid)item,item.Descripcion);
            }


            return diccionario;
        }

        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.ventas)
            {
                sb.AppendLine(item.ObtenerDescripcionBreve());
            }


            return sb.ToString(); 
        }
        public void Vender(Producto producto) {

            this.Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad) {

            this.ventas.Add(new Venta(producto, cantidad));
        }


        public static bool operator ==(Comiqueria comiqueria,Producto producto) {
            Producto producto2 = comiqueria[(Guid)producto];
            bool iguales = false;
            if (producto2 != null) {
                if (string.Compare(producto.Descripcion,producto2.Descripcion) == 0 )
                {
                    iguales = true;
                }
            }


            return iguales;

        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto) {

            return !(comiqueria == producto);
        }


        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto) {


            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }

    }
}
