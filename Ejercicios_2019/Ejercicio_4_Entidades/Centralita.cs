using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Entidades
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita() {
            this.listaLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this() {
            this.razonSocial = nombreEmpresa;
        }
        #region Propiedades
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }
        public float GananciasPorProvincia
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        #endregion

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo) {

            float suma = 0;

            foreach (var item in this.listaLlamadas)
            {

                if (item.GetType().ToString() == tipo.ToString()) {
                   suma += item.CostoLlamada;
                }
            }
          

            return suma;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ganacia Total: " + this.GananciasPorTotal);
            sb.AppendLine("Ganacia Provincia: " + this.GananciasPorProvincia);
            sb.AppendLine("Ganacia Local: " + this.GananciasPorLocal);

            foreach (var item in this.listaLlamadas)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            //this.listaLlamadas.Sort();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public static bool operator  ==(Centralita c,Llamada llamada){

            bool existe = false;

            foreach (var item in c.listaLlamadas)
            {
                if (item == llamada) {

                    existe = true;
                }
              
            }
            return existe;
        }
        public static Centralita operator  +(Centralita c, Llamada nuevaLlamada)
        {

            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
          }

            public static bool operator !=(Centralita c, Llamada llamada){

                    return !(c == llamada);

                }
        }

}
