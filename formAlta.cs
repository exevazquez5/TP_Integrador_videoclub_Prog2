using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_integrador_prog2_videoclub
{
    public partial class formAlta : Form
    {
        CN_Peliculas objetoCN = new CN_Peliculas();
        public formAlta()
        {
            InitializeComponent();
            // Configurar la posición de inicio para centrar en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAltaPelicula(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarPelicula(txbTitulo.Text, txbActor.Text, txbDirector.Text, cbxGenero.Text, txbDuracion.Text, txbPrecio.Text, txbCantRecibida.Text);
                MessageBox.Show("se inserto correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
        }

        private void btnAtras(object sender, EventArgs e)
        {
            Form1 pantallaInicio = new Form1();
            pantallaInicio.Show();
            this.Hide();
        }
    }
}
