using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    class Comiqueria
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
         public IDictionary<Guid,string> ListarProductos()
        {


        }

        public string ListarVentas()
        {


        }
        public void Vender(Producto producto) {

            this.Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad) {

            this.ventas.Add();
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
