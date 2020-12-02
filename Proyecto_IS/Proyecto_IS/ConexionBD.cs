using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proyecto_IS
{
    class ConexionBD
    {
        string cadena = "Data source = LAPTOP-VC0EO7D8\\SQLEXPRESS;Initial Catalog = PractiTec; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public void Conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Abierta");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }

        public void Cerrar()
        {
            conectarbd.Close();
        }
       

    }
}
