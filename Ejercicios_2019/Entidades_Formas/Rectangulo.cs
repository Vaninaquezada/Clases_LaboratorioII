using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Formas
{
   public class Rectangulo : Figura
    {
        public double baseR;
        public double altura;

        public Rectangulo(double baseR,double altura) {

            this.baseR = baseR;
            this.altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return this.CalcularSuperficie() * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.baseR * this.altura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

    }
}
