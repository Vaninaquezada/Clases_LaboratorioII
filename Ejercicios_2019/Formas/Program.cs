using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Formas;
namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figura = new List<Figura>();

            figura.Add(new Circulo(2));
            figura.Add(new Cuadrado(3));
            figura.Add(new Rectangulo(4,8));


            Console.WriteLine("Tipo: {0}", figura[0].GetType().ToString());
            Console.WriteLine(figura[0].Dibujar());
            Console.WriteLine("Perimetro: {0}", figura[0].CalcularPerimetro());
            Console.WriteLine("Superficie: {0}", figura[0].CalcularSuperficie());
            Console.WriteLine("***********************************");
            Console.WriteLine("Tipo: {0}", figura[1].GetType().ToString());
            Console.WriteLine(figura[1].Dibujar());
            Console.WriteLine("Perimetro: {0}", figura[1].CalcularPerimetro());
            Console.WriteLine("Superficie: {0}", figura[1].CalcularSuperficie());
            Console.WriteLine("***********************************");
            Console.WriteLine("Tipo: {0}", figura[2].GetType().ToString());
            Console.WriteLine(figura[2].Dibujar());
            Console.WriteLine("Perimetro: {0}", figura[2].CalcularPerimetro());
            Console.WriteLine("Superficie: {0}", figura[2].CalcularSuperficie());
            Console.WriteLine("***********************************");

            Console.ReadKey();
        }
    }
}
