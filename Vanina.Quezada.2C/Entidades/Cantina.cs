using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        /// <summary>
        /// propiedad devuelve la lista de botellas
        /// </summary>
        public List<Botella> Botellas
        {
            get { return this.botellas; }
        }
        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            this.botellas = new List<Botella>();
        }


        /// <summary>
        /// metodo singleton valida si ya esta intanciada cantina, si no hay instancia de cantina crea una 
        /// </summary>
        /// <param name="espacios">cantidad de espacios disponibles en la lista botellas</param>
        /// <returns></returns>

        #region Metodos
        public static Cantina GetCantina(int espacios) {

            if (Cantina.singleton == null) {

                Cantina.singleton = new Cantina(espacios);
            }
            else{
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }
        /// <summary>
        /// Agrega las botellas a la lista
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator +(Cantina c, Botella b )
        {
            
            if (c.espaciosTotales > c.botellas.Count)
            {
                c.botellas.Add(b);
                return true;

            }

            return false;
        }


        #endregion


    }
}
