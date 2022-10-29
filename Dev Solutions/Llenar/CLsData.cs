using Dev_Solutions.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Solutions.Llenar
{
    public class CLsData
    {
        public List<ClsDepartamentos> ObtenerDepartamentos()
        {
            List<ClsDepartamentos> oListaDepartamentos = new List<ClsDepartamentos>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("USP_ObtenerDepartamentos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaDepartamentos.Add(new ClsDepartamentos
                    {
                        Dpto_ID = Convert.ToInt32(dr["Dpto_ID"]),
                        Dpto_Nombre = Convert.ToString(dr["Dpto_Nombre"].ToString())
                    });
                }
                dr.Close();

            }
            return oListaDepartamentos;
        }

        public List<ClsMunicipios> ObtenerMunicipios(int Dpto_ID)
        {
            List<ClsMunicipios> oListaMunicipios = new List<ClsMunicipios>();
            using (SqlConnection oConexion = new SqlConnection(Configuracion.conexion))
            {
                SqlCommand cmd = new SqlCommand("USP_ObtenerMunicipios", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Dpto_ID", Dpto_ID);
                cmd.CommandTimeout = 600;
                oConexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    oListaMunicipios.Add(new ClsMunicipios
                    {
                        //Mpio_ID = Convert.ToInt32(dr["Mpio_ID"]),
                        Mpio_Nombre = Convert.ToString(dr["Mpio_Nombre"].ToString())
                    });


                }

                dr.Close();
            }

            return oListaMunicipios;
        }
    }
}
