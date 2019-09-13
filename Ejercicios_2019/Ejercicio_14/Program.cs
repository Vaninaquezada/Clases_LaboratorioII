using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            System.Console.WriteLine("Ingrese la medida del lado del cuadrado");
            ladoCuadrado= Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese la base del triangulo");
            baseTriangulo = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese la altura del triangulo");
            alturaTriangulo = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Ingrese el radio del circulo");
            radioCirculo = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Area del cuadrado: {0}",CalculoDeArea.CalcularCuadrado(ladoCuadrado));
            System.Console.WriteLine("Area del triangulo: {0}",CalculoDeArea.CalcularTriangulo(baseTriangulo,alturaTriangulo));
            System.Console.WriteLine("Area del  circulo: {0}",CalculoDeArea.CalcularCirculo(radioCirculo));

            System.Console.ReadKey();

        }
    }
}
