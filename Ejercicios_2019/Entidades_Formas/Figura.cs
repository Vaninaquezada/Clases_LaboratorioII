using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Formas
{
    public abstract class Figura
    {
        /// <summary>
        /// Tendrá una implementación por defecto en la clase base, retornará
       ///“Dibujando forma…”.
        /// </summary>
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();
    }
}
