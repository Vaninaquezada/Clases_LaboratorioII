using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Ingrese un numero:");
            int entrada = Convert.ToInt32(System.Console.ReadLine());


            while(entrada == 0){

                System.Console.WriteLine("ERROR. ¡Reingresar número!");
                entrada = Convert.ToInt32(System.Console.ReadLine());

            }
            System.Console.WriteLine("Cuadrado del numero ingresado es {0}",Math.Pow(entrada,2));
            System.Console.WriteLine("Cubo del numero ingresado es {0}", Math.Pow(entrada, 3));
            System.Console.ReadKey();


        }
    }
}
