using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoRichBox = rtbox.Text;
            String[] palabras = textoRichBox.Split( ' ', ',', '.', ':', '\t');
            Dictionary<string, int> dicPalabras = new Dictionary<string, int>();

            foreach (var item in palabras)
            {
                if(dicPalabras.ContainsKey(item.ToLower()))
                {
                    dicPalabras[item.ToLower()] += 1; 
                }
                else
                {
                    dicPalabras.Add(item.ToLower(), 1);
                }
            }



            StringBuilder sb = new StringBuilder();
            foreach (var item in dicPalabras)
            {
                sb.Append(item.Key.ToString());
               sb.Append(" ");
               sb.AppendLine(item.Value.ToString());
               //sb.AppendLine(item.ToString());
            }

            MessageBox.Show(sb.ToString());

        }
    }
}
