using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0, numero2 = 0;
            string operacion;

            System.Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Ingrese la operacion que desea realizar (+,-,*,/): ");
            operacion = System.Console.ReadLine();

            System.Console.WriteLine("El resultado de {0} {1} {2} es {3}",numero1, operacion, numero2,Calculadora.Calcular(numero1,numero2,operacion));

            System.Console.ReadKey();
        }
    }
}
