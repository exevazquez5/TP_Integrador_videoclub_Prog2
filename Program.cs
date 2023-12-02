using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_integrador_prog2_videoclub
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            conexionDB conexion = new conexionDB();

            if (conexion.ProbarConexion())
            {
                Console.WriteLine("La conexión a la base de datos es exitosa.");
            }
            else
            {
                Console.WriteLine("Hubo un problema al conectar con la base de datos.");
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}