using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Title = "Clase 1";
              Console.BackgroundColor = ConsoleColor.DarkMagenta;
              Console.ForegroundColor = ConsoleColor.Black;
              string nombre = "Vani";
              string saludo = "Hola";
              System.Console.WriteLine("{1} {0}!!",nombre,saludo);

              System.Console.ReadKey();
           */
            //Ejercicio 1
            /*
             * 1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
             *valor máximo, el valor mínimo y el promedio.
            */

            int max=0;
            int min=0;
            int acu = 0;

            int num;

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Ingrese el numero {0} ",i + 1);

                num = Convert.ToInt32(System.Console.ReadLine());


                acu += num;

                if (i == 0) {
                    max = num;
                    min = num;
                } else if ( num > max) {
                    max = num;

                } else if (num < min)
                {
                    min = num;

                }


            }
            System.Console.WriteLine("Maximo {0}", max);
            System.Console.WriteLine("Minimo {0}", min);
            System.Console.WriteLine("Promedio {0}", acu / 5.0 );
            System.Console.ReadKey();


        }
    }
      }
