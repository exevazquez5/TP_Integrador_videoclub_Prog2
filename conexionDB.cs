using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_integrador_prog2_videoclub
{
    using System;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    internal class conexionDB
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-5HL211H\\SQLEXPRESS;DataBase=videoclub;Integrated Security=true");

        public bool ProbarConexion()
        {
            try
            {
                AbrirConexion();
                return true; // La conexión fue exitosa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

