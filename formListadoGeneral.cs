using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_integrador_prog2_videoclub
{
    public partial class formListadoGeneral : Form
    {
        public formListadoGeneral()
        {
            InitializeComponent();
            // Configurar la posición de inicio para centrar en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formListadoGeneral_Load(object sender, EventArgs e)
        {
            MostrarPeliculas();
            dgvListadoGeneral.AutoGenerateColumns = true;
        }
        private void MostrarPeliculas()
        {
            CN_Peliculas objeto = new CN_Peliculas();
            dgvListadoGeneral.DataSource = objeto.MostrarPeliculas();
        }

        private void btnAtras(object sender, EventArgs e)
        {
            formBuscar pantallaBuscar = new formBuscar();
            pantallaBuscar.Show();
            this.Hide();
        }
    }
}
