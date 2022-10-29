using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Solutions
{
    public partial class Inicio : Form
    {
        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        string server = "Data Source=GABRIEL;Initial Catalog=Bd_ProyectoFinal;Integrated Security=True";
        SqlConnection conectar = new SqlConnection();
        Conexion con = new Conexion();
        public Inicio()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_dpi_busqueda", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dpi", dpi.Text);
            cmd.Parameters.AddWithValue("@fec_nac", FechaN.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            string sp = "sp_dpi_busqueda" + "'" + dpi.Text + "'" + "," + "'" + FechaN.Text + "'";
            con.mostrar(sp, primaryGrid);
            conectar.Close();

        }

        private void BORRAR_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.mostrar("productos", primaryGrid);
        }

        private void FechaN_TextChanged(object sender, EventArgs e)
        {

        }

        private void primaryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmpadronarse_Click(object sender, EventArgs e)
        {
            
            Registro ed = new Registro();
            this.Hide();
            ed.Show();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("sp_dpi_busqueda", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dpi", dpi.Text);
            cmd.Parameters.AddWithValue("@fec_nac", FechaN.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            string sp = "sp_dpi_busqueda" + "'" + dpi.Text + "'" + "," + "'" + FechaN.Text + "'";
            con.mostrar(sp, primaryGrid);
            conectar.Close();
        }
    }
}
