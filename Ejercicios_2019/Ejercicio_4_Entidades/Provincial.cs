using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Entidades
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        #region Enum Franja
        public enum Franja
        {
            Frnaja_1,
            Franja_2,
            Franja_3
        }
        #endregion

        public Provincial(Franja mifranja,Llamada llamada):this(llamada.NroOrigen, mifranja,llamada.NroDestino, llamada.Duracion) { }
        public Provincial(string origen,Franja mifranja,string destino, float duracion):base(duracion,destino,origen) {
            this.franjaHoraria = mifranja;
        }

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }
        private float CalcularCosto()
        {
            double costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Frnaja_1:
                    costo = this.Duracion * 0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.Duracion * 1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.Duracion * 0.66;
                    break;
                default:
                    costo = 0;
                    break;
            }

            return (float)costo;

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.CostoLlamada.ToString());
            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
