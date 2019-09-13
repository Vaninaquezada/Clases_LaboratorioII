using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo= 0;
            int maximo=0;
            int acumulador = 0;
           

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Ingrese numero {0}",i+1);
                numero = Convert.ToInt32(System.Console.ReadLine());
                while (!Validacion.Validar(numero,-100,100)) {
                    System.Console.WriteLine("Numero no valido reingrese numero {0}", i + 1);
                    numero = Convert.ToInt32(System.Console.ReadLine());
                }

                if(i == 0)
                {
                    minimo = numero;
                    maximo = numero;

                }else if(numero < minimo)
                {
                    minimo = numero;
                }else if (numero > maximo)
                {
                    maximo = numero;
                }

                acumulador += numero;
            }

            System.Console.WriteLine("Minimo: {0}",minimo);
            System.Console.WriteLine("Maximo: {0}",maximo);
            System.Console.WriteLine("Promedio: {0}", acumulador/10.0);
            System.Console.WriteLine("Acumulador: {0}", acumulador);
            System.Console.ReadKey();

        }
    }
}
