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
    public partial class formEditar : Form
    {
        public formEditar()
        {
            InitializeComponent();
            // Configurar la posición de inicio para centrar en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

    private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPelicula(object sender, EventArgs e)
        {
            // Agregar el control de usuario personalizado al formulario
            editarControl editControl = new editarControl();

            // Establece la posición del control en el formulario
            editControl.Location = new Point(50, 50);

            // Agrega el control al formulario
            this.Controls.Add(editControl); 
        }

        private void btnAtras(object sender, EventArgs e)
        {
            formAdministrar pantallaAdministrar = new formAdministrar();
            pantallaAdministrar.Show();
            this.Hide();
        }
    }
}
