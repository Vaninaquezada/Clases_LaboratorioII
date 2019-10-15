using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Plastico,
            Vidrio
        }

        #region Propiedades

        /// <summary>
        /// Convierte la capacidad en ml a litros
        /// </summary>
        public int CapacidadLitros
        {
            get { return this.capacidadML / 1000; }

        }

        /// <summary>
        /// Valida que el contenido de la botella no supera la capacidad de la misma
        /// </summary>
        public int Contenido
        {
            get { return this.contenidoML; }
            set {
                    if (value <= this.capacidadML) {
                        this.contenidoML = value;
                    }
                    else
                    {
                        this.contenidoML = capacidadML;
                    }
              }
        }

        /// <summary>
        /// Devuelve el porcentaje del contenido de la botella
        /// </summary>
        public float PorcentageContenido
        {
            get { return (contenidoML * 100) / (float)capacidadML; }

        }


        #endregion
        #region Metodos
        /// <summary>
        /// inicializa los campos de la botella
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        protected Botella(string marca,int capacidadML,int contenidoML) {
            this.capacidadML = capacidadML;
            this.Contenido = contenidoML;
            this.marca = marca;
        }/// <summary>
        /// Arma string con los datos de la botella
        /// </summary>
        /// <returns>string con los datos de la botella</returns>
        protected  virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ");
            sb.AppendLine(this.marca);
           sb.AppendFormat("Capacidad: {0} \n \r",this.capacidadML);
     
            sb.AppendFormat("Contenido: {0} \n \r", this.contenidoML);

            return sb.ToString();
        }
        public abstract int ServirMedida();


        /// <summary>
        /// devuelve los datos generados en  el metodo generar informe
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion
    }
}
