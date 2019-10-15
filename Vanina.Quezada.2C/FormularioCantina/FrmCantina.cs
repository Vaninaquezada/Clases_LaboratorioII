using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlesUsuario;

namespace FormularioCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }
/// <summary>
/// On click del boon agregar se verifica si es agua o cerveza, se crea el objeto correspondiente y se agrega ala lista botellas
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
        Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);


            if (rdbtnAgua.Checked)
            {
               
                      Agua agua = new Agua(Convert.ToInt32(nupdoCapacidad.Value),txtbMarca.Text, Convert.ToInt32(numericUpDown2.Value));
                this.barra1.AgregarBotella(agua);
            }
            else if (rdbtnCerveza.Checked) {

                Cerveza cerveza = new Cerveza(Convert.ToInt32(nupdoCapacidad.Value), txtbMarca.Text, tipo, Convert.ToInt32(numericUpDown2.Value));
                this.barra1.AgregarBotella(cerveza);

            }
            else
            {
                MessageBox.Show("Seleccione cerveza o agua");

            }

          


        }
    }
}
