using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace Dev_Solutions
{
    internal class ClsOperaciones
    {
        ClsConexion cn = new ClsConexion();

        public DataTable CargarDepartamentos()
        {
            SqlDataAdapter da = new SqlDataAdapter("USP_ObtenerDepartamentos", cn.CreateConnection());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
