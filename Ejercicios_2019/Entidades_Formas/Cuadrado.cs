using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Formas
{
    public sealed class Cuadrado : Rectangulo
    {
        public double lado;

        public Cuadrado(double lado):base(lado,lado)
        {

            this.lado = lado;
        }

        
    }
}
