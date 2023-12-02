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
    public partial class formBuscar : Form
    {
        public formBuscar()
        {
            InitializeComponent();
            // Configurar la posición de inicio para centrar en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAtras(object sender, EventArgs e)
        {
            Form1 pantallaInicio = new Form1();
            pantallaInicio.Show();
            this.Hide();
        }

        private void btnListadoGeneral(object sender, EventArgs e)
        {
            formListadoGeneral pantallaListadoGeneral = new formListadoGeneral();
            pantallaListadoGeneral.Show();
            this.Hide();
        }
    }
}
