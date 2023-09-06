using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialCalderon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Jose Alfredo Calderon Bermudez
        //Parcial 1  USIS054821
        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            {
                int de, a;
                double cantidad, respuesta;

                de = cbodeconversores.SelectedIndex;
                a = cboaconversores.SelectedIndex;

                cantidad = double.Parse(txtcantidadcoversores.Text);

                double[] medida = { 0.09290304, 0.698896, 0.836127, 1, 438, 7000, 10000, };

                respuesta = medida[de] / medida[a] * cantidad;
                lblRespuestaConversores.Text = " Respuesta " + Math.Round(respuesta, 2);
            }
        }

        private void lblDE_Click(object sender, EventArgs e)
        {

        }
    }
}
