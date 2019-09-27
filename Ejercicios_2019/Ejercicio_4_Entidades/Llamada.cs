using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Entidades
{
    public  abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        public abstract float CostoLlamada
        {
            get;
        
        }
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }



        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas

        }

        public Llamada(float duracion,string nroDestino,string nroOrigen) {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("Numero Destino: " + this.nroDestino);
            sb.AppendLine("Numero Origen: " + this.nroOrigen);
            return sb.ToString();
        }
         public static bool operator ==(Llamada l1, Llamada l2) {

            bool iguales = false;

            if (l1.Equals(l2))
            {
                if (l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
                {
                    iguales = true;
                }

            }

            return iguales;
        }
        public static bool operator !=(Llamada l1, Llamada l2) {
            return !(l1 == l2);
        }

        public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int rsp = 0; 

            if (llamada1.duracion > llamada2.duracion)
            {

                rsp = 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                rsp = -1;
            }

            return rsp;

        }

    }
}
