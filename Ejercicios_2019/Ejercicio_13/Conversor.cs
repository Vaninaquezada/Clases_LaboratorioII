using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
   public class Conversor
    {
        /*
         * string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.
*/
        public static string DecimalBinario(double numDecimal) {

            return "wwqw";
        }


        public static double BinarioDecimal(string binario) {
            double numDecimal;
            if (Double.TryParse(binario, out numDecimal)) {
                return numDecimal;

            }
            return 0;
        }


    }
}
