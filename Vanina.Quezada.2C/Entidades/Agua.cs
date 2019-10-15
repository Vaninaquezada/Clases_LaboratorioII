using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Agua :Botella
    {

        private const int MEDIDA = 400;


        #region Constructores

        public Agua(int capacidadML, string marca,  int contenidoML) : base(marca, capacidadML, contenidoML)
        {
           
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Arma string con los datos del agua
        /// </summary>
        /// <returns>string con los datos del agua</returns>
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.GenerarInforme());
            sb.AppendFormat("Medida: {0} \n", Agua.MEDIDA.ToString());
            return sb.ToString();
        }


        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }
        /// <summary>
        /// Valida el contenido y lo reduce segun la medida que se sirva
        /// </summary>
        /// <param name="medida"></param>
        /// <returns></returns>
        public  int ServirMedida(int medida)
        {
            if (medida <= base.Contenido)
            {
                base.Contenido = base.Contenido - medida;
            }
            else
            {
                base.Contenido = 0;
            }

            return base.Contenido;
        }
        #endregion

    }
}
