using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_integrador_prog2_videoclub
{
    internal class CD_Peliculas
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        private conexionDB conexion = new conexionDB();
        SqlCommand command = new SqlCommand();
        
        public DataTable ListadoGeneral()
        {
            string query = "SELECT * FROM Peliculas";

            command.Connection = conexion.AbrirConexion();
            command.CommandText = query;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }

        public void insertarPelicula(string txbTitulo, string txbActor, string txbDirector, string cbxGenero, int txbDuracion, double txbPrecio, int txbCantRecibida)
        {
            string query = "INSERT INTO Peliculas (titulo, actor, director, genero, duracion, precio, cant_recibida)" +
            " VALUES (@titulo, @actor, @director, @genero, @duracion, @precio, @cant_recibida)";

            command.Connection = conexion.AbrirConexion();
            command.CommandText = query;
            command.Parameters.AddWithValue("@titulo", txbTitulo);
            command.Parameters.AddWithValue("@actor", txbActor);
            command.Parameters.AddWithValue("@director", txbDirector);
            command.Parameters.AddWithValue("@genero", cbxGenero);
            command.Parameters.AddWithValue("@duracion", txbDuracion);
            command.Parameters.AddWithValue("@precio", txbPrecio);
            command.Parameters.AddWithValue("@cant_recibida", txbCantRecibida);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void editarPelicula(int txbCodPelicula, string txbTitulo, string txbActor, string txbDirector, string cbxGenero, int txbDuracion, double txbPrecio, int txbCantRecibida)
        {
            string query = "UPDATE Peliculas " +
                "SET titulo = @titulo, actor = @actor, director = @director, genero = @genero, duracion = @duracion, precio = @precio, cant_recibida = @cant_recibida" +
                "WHERE cod_pelicula = @cod_pelicula";

            command.Connection = conexion.AbrirConexion();
            command.CommandText = query;
            command.Parameters.AddWithValue("@cod_pelicula", txbCodPelicula);
            command.Parameters.AddWithValue("@titulo", txbTitulo);
            command.Parameters.AddWithValue("@actor", txbActor);
            command.Parameters.AddWithValue("@director", txbDirector);
            command.Parameters.AddWithValue("@genero", cbxGenero);
            command.Parameters.AddWithValue("@duracion", txbDuracion);
            command.Parameters.AddWithValue("@precio", txbPrecio);
            command.Parameters.AddWithValue("@cant_recibida", txbCantRecibida);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void eliminarPelicula(int txbCodPelicula)
        {

            string query = "DELETE FROM Peliculas WHERE cod_pelicula = @cod_pelicula";

            command.Connection = conexion.AbrirConexion();
            command.CommandText = query;
            command.Parameters.AddWithValue("@cod_pelicula", txbCodPelicula);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}
