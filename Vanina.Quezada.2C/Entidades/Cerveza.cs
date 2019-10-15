using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {

        private const int MEDIDA = 330;
        private Tipo tipo;


        #region Constructores
        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        { }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Guarda los datos de la cerveza y los retorna formateados
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.AppendFormat("Tipo: {0} \n ", this.tipo);
            sb.AppendFormat("Medida: {0} \n", Cerveza.MEDIDA.ToString());
            return sb.ToString();
        }
        /// <summary>
        /// Retorna el tipo de la cerveza recibida
        /// </summary>
        /// <param name="cerveza">cerveza de cual se quiere saber el tipo</param>
        public static implicit  operator Tipo(Cerveza cerveza){

            return cerveza.tipo;

            }

        /// <summary>
        /// Si la medida es menor al contenido, usa el contenido de la botella  
        /// </summary>
        /// <returns>cantidad disponible</returns>
        public override int ServirMedida()
        {
            if (Cerveza.MEDIDA <= base.Contenido) {

                base.Contenido = base.Contenido - (int)(Cerveza.MEDIDA * 0.80);
            }
            else {

                base.Contenido = 0;
            }


            return base.Contenido;
        }
        #endregion
    }
}
