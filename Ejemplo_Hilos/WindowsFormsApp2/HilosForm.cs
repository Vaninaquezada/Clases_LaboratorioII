using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HilosForm : Form
    {
      

        private delegate void Callback(object i);
        private Thread hilo;
        public HilosForm()
        {
           
            InitializeComponent();
        }

        private void buttonEscribir_Click(object sender, EventArgs e)
        {
            this.richTextBoxTexto.Text += this.textBoxEscribir.Text + "\n";

           
            this.textBoxEscribir.Clear();
        }

        private void HilosForm_Load(object sender, EventArgs e)
        {
           
            //Thread hilo = new Thread(new ThreadStart(Contar));
             hilo = new Thread(new ParameterizedThreadStart(Contar));
            hilo.Start(30);
        }

        private void Contar(object salto)
        {

            while(true)
            {
                this.ActualizarLabel(Convert.ToInt32(salto));
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel(object saltito)
        {
            Object[] obj = new object[]{saltito};

            if (this.labelContador.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarLabel);
                this.labelContador.Invoke(callback, saltito);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int)saltito).ToString();
            }
        }



        private void HilosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }

        }

        //private void ContarASaltos(object cantidadASaltar)
        //{
        //    while(true)
        //    {
        //        this.ActualizarLabel(cantidadASaltar);
        //        Thread.Sleep(1000);
        //    }
        //}

        //private void ActualizarLabel(object cantidadASaltar)
        //{
        //    if (this.labelContador.InvokeRequired)
        //    {
        //        object[] parametros = new object[] { cantidadASaltar };
        //        this.labelContador.Invoke(new Callback(this.ActualizarLabel), parametros);
        //    }
        //    else
        //    {
        //        this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int) cantidadASaltar).ToString();
        //    }
        //}
    }
}
