using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Listas();
            //PilasyColas();
           Diccionario();
        }

        private static int Compare(int x, int y)
        {
            if (x < y) {
                return -1;
            } else if (x > y) {
                return 1;
            }
            return 0;
        }
        private static void Mostrar(List<int> lista)
        {


            foreach (var item in lista)
            {
                System.Console.WriteLine("{0}", item);
            }
            System.Console.ReadKey();



        }

        private static void Listas()
        {
            List<int> numeros = new List<int>();
            Random r = new Random();


            for (int i = 0; i < 5; i++)
            {
                numeros.Add(r.Next(1000));
            }

            Mostrar(numeros);

            numeros.Sort(Compare);
              System.Console.WriteLine("/////////////");
             Mostrar(numeros);

        }
        private static void Diccionario()
        {
            Dictionary<string, string> persona = new Dictionary<string, string>();

            persona.Add("30215487", "Lautaro Mota");
            persona.Add("22154877", "Martin Lota");
            persona.Add("21588789", "Kero Sen");
            persona.Add("2015489", "Sera Kirna");
            persona.Add("46546885", "Kako Kacoso");

            foreach (var item in persona)
            {
                System.Console.WriteLine("{0} {1}", item.Key,item.Value);
            }
            System.Console.ReadKey();

        }
        private static void PilasyColas() {

            Random r = new Random();
            List<int> numeros = new List<int>();

            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();


            for (int i = 0; i < 5; i++)
            {
                numeros.Add(r.Next(1000));


            }
                System.Console.WriteLine("/////////////Lista/////////////");
            for (int i = 0; i < 5; i++)
            {
                      System.Console.WriteLine("{0}", numeros[i]);
                pila.Push(numeros[i]);

            }
                System.Console.ReadKey();
            System.Console.WriteLine("\n/////////////Pila/////////////");
            foreach (var item in pila)
            {
                          System.Console.Write("{0} ", item);
                cola.Enqueue(item);
            }
               System.Console.ReadKey();

                System.Console.WriteLine("\n/////////////Cola/////////////");

            foreach (var item in cola)
            {
                      System.Console.Write("{0} ", item);
            }
                System.Console.ReadKey();


        }
    }
}
