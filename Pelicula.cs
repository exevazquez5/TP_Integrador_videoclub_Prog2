using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_integrador_prog2_videoclub
{
    public class Pelicula
    {
        private int cod_pelicula {  get; set; }
        private string titulo {  get; set; }

        private List<string> actores = new List<string>();
        private string director {  get; set; }
        private string genero { get; set; }
        private int duracion { get; set; }
        private int cantidadRecibido { get; set; }
        private double precioAlquiler { get; set; }
        private DateTime fechaIngreso { get; set; }
        private int cantidadStock { get; set; }
        private int cantidadAlquilada { get; set; }

        public Pelicula(int cod_pelicula, string titulo, List<string> actores, string director, string genero, int duracion, int cantidadRecibido, double precioAlquiler, DateTime fechaIngreso, int cantidadStock, int cantidadAlquilada)
        {
            this.cod_pelicula=cod_pelicula;
            this.titulo=titulo;
            this.actores=actores;
            this.director=director;
            this.genero=genero;
            this.duracion=duracion;
            this.cantidadRecibido=cantidadRecibido;
            this.precioAlquiler=precioAlquiler;
            this.fechaIngreso=fechaIngreso;
            this.cantidadStock=cantidadStock;
            this.cantidadAlquilada=cantidadAlquilada;
        }
        /*
        public borrarPelicula(int cod_pelicula)
        {

        }

        public editarPelicula(int cod_pelicula)
        {

        }

        public mostrarTodasPeliculas()
        {

        }
        */

        /*
        public darAltaPelicula()
        {


        }*/
    }
}
