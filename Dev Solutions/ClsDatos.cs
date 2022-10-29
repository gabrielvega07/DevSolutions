using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ClsDatos
    {
        //metodo para listar elementos de tabla personas
        public DataTable Listar()
        {
            //leer la secuencia de fials dentro de la tabla SQL
            SqlDataReader lista;
            DataTable Table = new DataTable();

            //consexion
            SqlConnection con = new SqlConnection();
            try
            {
                string SQL = "Select * from Personas";
                con = ClsConexion.CrearInstancia().CreateConnection(); //obtiene el string de conexion a SQL
                SqlCommand cmd = new SqlCommand(SQL, con);
                con.Open();
                lista = cmd.ExecuteReader();
                Table.Load(lista);
                return Table;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    //detiene la conexion
                }
            }
        }
    }
}
