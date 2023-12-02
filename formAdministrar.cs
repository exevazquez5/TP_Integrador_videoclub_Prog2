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
    public partial class formAdministrar : Form
    {
        public formAdministrar()
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

        private void btnEditar(object sender, EventArgs e)
        {
            formEditar formEditar = new formEditar();
            formEditar.Show();
            this.Hide();
        }

        private void btnBorrar(object sender, EventArgs e)
        {

        }
    }
}
