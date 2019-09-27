using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Entidades
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(float costo, Llamada llamada) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, llamada.CostoLlamada) { }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }
        private float CalcularCosto()
        {
          

            return this.costo * this.duracion;

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo llamada: " + this.CostoLlamada.ToString());
            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
