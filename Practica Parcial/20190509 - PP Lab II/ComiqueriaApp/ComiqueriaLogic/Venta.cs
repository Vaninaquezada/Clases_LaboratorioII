using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return fecha; }
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
         }
        internal  Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        private void Vender (int cantidad) {
            this.fecha = DateTime.Now;
            producto.Stock = producto.Stock - cantidad;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio,cantidad);

        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precio = precioUnidad * cantidad;

            //return precio * (Venta.porcentajeIva / 100);
            return precio * (1 + 21 / 100.0);
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.fecha.ToString());
            sb.Append(" - ");
            sb.Append(producto.Descripcion);
            sb.Append(" - ");
            sb.Append(string.Format("{0:0.00}",this.precioFinal));
            return sb.ToString();
        }


    }
}
