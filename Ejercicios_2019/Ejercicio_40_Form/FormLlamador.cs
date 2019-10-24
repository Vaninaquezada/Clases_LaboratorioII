using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_4_Entidades;
namespace Ejercicio_40_Form
{
    public partial class FormLlamador : Form
    {


        private Centralita centralita;

        public FormLlamador()
        {
           
            InitializeComponent();
        }
        public FormLlamador(Centralita centralita):this()
        {
            this.centralita = centralita;
        }


        public Centralita Centralita
        {
            get { return this.centralita; }
           
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Llamada.TipoLlamada));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Text = "sad";            //this.ActiveControl;

            if(this.ActiveControl == txtbxNroOrigen)
            {
                txtbxNroOrigen.Text = "Nwer";

            }
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtboxNroDestino.Text = "Nro Destino";
            txtbxNroOrigen.Text = "Nro Origen";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string numero = txtboxNroDestino.Text;
            switch (numero[0])
            {
                case '#':
                 //   centralita =+ new
                    break;
                case '*':

                    break;
                default:

                    MessageBox.Show("Numero destino no valido");

                    break;
            }
        }
    }
}
