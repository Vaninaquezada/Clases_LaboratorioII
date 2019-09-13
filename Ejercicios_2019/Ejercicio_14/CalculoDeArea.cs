using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero) {
            return Math.Pow(numero,2);
        }
        public static double CalcularTriangulo(double numeroBase,double numeroAltura) {
            return (numeroBase * numeroAltura) / 2;
        }
        public static double CalcularCirculo(double numero) {


            return Math.Pow(numero,2) * Math.PI;

        }

    }
}
