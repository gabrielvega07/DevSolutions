using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public class ClsConexion
    {
        //variables
        private string DB;
        private string Server;
        private string User;
        private string Password;

        //metodo de autenticacion
        private bool security;

        //objeto de conexion
        private static ClsConexion con = null;

        public ClsConexion()
        {
            this.DB = "Test";
            this.Server = "GABRIEL";
            this.User = "sa";
            this.Password = "2125Pablo/";
            this.security = true;
        }

        //obrener string de conexion
        public SqlConnection CreateConnection()
        {
            //variable para conexion
            SqlConnection cadena = new SqlConnection();
            try
            {
                //cadena de conexion
                cadena.ConnectionString = "Server =" + this.Server + "; Database=" + this.DB + ";";

                //validar el metodo de conexion
                if (this.security)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";

                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.User + "; Password=" + this.Password;

                }

            }
            catch (Exception)
            {
                cadena = null;
                throw; //mensaje de error de la conexion por consola

            }
            return cadena;
        }

        //metodo para generar instancia al constructor dentro de la clase
        //para asignar las variables al constructor
        public static ClsConexion CrearInstancia()
        {
            if (con == null)
            {
                con = new ClsConexion();
            }
            return con;
        }
    }
}
