using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_integrador_prog2_videoclub
{
    internal class CN_Peliculas
    {
        private CD_Peliculas objetoCD = new CD_Peliculas();
        public DataTable MostrarPeliculas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListadoGeneral();
            return tabla;
        }

        public void InsertarPelicula(string txbTitulo, string txbActor, string txbDirector, string cbxGenero, string txbDuracion, string txbPrecio, string txbCantRecibida)
        {
            int duracion;
            double precio;
            int cantRecibida;

            if (int.TryParse(txbDuracion, out duracion) &&
                double.TryParse(txbPrecio, out precio) &&
                int.TryParse(txbCantRecibida, out cantRecibida))
            {
                objetoCD.insertarPelicula(txbTitulo, txbActor, txbDirector, cbxGenero, duracion, precio, cantRecibida);

            }
            else
            {
                // Manejo de error: Las conversiones no fueron exitosas
                // Podrías mostrar un mensaje al usuario indicando que los valores ingresados no son válidos
                MessageBox.Show("Alguno de los valores ingresados no es válido.");
            }
        }

    }
}
