using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Solutions
{
    internal class Conexion
    {
        public void mostrar(String tabla, DataGridView grid)
        {
            string server = "Data Source = GABRIEL; Initial Catalog=Bd_ProyectoFinal; Integrated Security = True";
            SqlConnection conectar = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable contenedor = new DataTable();
            conectar.ConnectionString = server;
            conectar.Open();
            string query = "Exec " + tabla;
            SqlCommand cmd = new SqlCommand(query, conectar);
            try
            {
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(contenedor);
                grid.DataSource = contenedor;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                throw;
            }
            conectar.Close();
        }
    }
}
