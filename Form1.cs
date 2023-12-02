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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Configurar la posición de inicio para centrar en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta(object sender, EventArgs e)
        {
            formAlta pantallaAlta = new formAlta();
            pantallaAlta.Show();  
            this.Hide();   
        }

        private void btnAdministrar(object sender, EventArgs e)
        {
            formAdministrar pantallaAdministrar = new formAdministrar();
            pantallaAdministrar.Show();
            this.Hide();
        }

        private void btnBuscar(object sender, EventArgs e)
        {
            formBuscar pantallaBuscar = new formBuscar();
            pantallaBuscar.Show();
            this.Hide();
        }

        private void btnSalir(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
