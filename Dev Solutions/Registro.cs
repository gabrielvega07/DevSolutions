using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dev_Solutions.Llenar;
using Dev_Solutions.Model;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using WinFormsApp1;

namespace Dev_Solutions
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ListarDepartamento();

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
          

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog(); 
            if(result == DialogResult.OK)
            {
                pictureFoto.Image = Image.FromFile(dialog.FileName);
            }

            
        }


        private void btnFirma_Click(object sender, EventArgs e)
        {

        }

        private void pictureFoto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureFirma.Image = new Bitmap(open.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsMunicipios oMunicipioSeleccionado = (ClsMunicipios)combMunicipios.SelectedItem;

        }

        private void ListarDepartamento()
        {
            combDepartamentos.DataSource = new CLsData().ObtenerDepartamentos();
            combDepartamentos.ValueMember = "Dpto_ID";
            combDepartamentos.DisplayMember = "Dpto_Nombre";

        }

        private void combDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsDepartamentos oDepartamentoSeleccionado = (ClsDepartamentos)combDepartamentos.SelectedItem;

            combMunicipios.DataSource = new CLsData().ObtenerMunicipios(oDepartamentoSeleccionado.Dpto_ID);
            combMunicipios.ValueMember = "Mpio_ID";
            combMunicipios.DisplayMember = "Mpio_Nombre";
        }

        private void InsertarDatos()
        {
            SqlConnection con = new SqlConnection(@"Data Source=GABRIEL;Initial Catalog=Test;Integrated Security=True");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("Insert Into Tb_Personas (Persona_DPI, Persona_Nombre1, Persona_Nombre2, Persona_Nombre3, Persona_Apellido1, Persona_Apellido2, Persona_Apellido3, Persona_FechaNac, Persona_Direccion, Persona_Telefono) Values('"+txtDPI.Text +"','"+txtNombre1.Text +"','"+txtNombre2.Text +"','"+txtNombre3.Text+"','"+txtApelldo1.Text+"','"+txtApellido2.Text+"','"+txtApellido3.Text+"','"+txtFechaNa.Text+"','"+txtDireccion.Text+"','"+txtTelefono.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureFoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                byte[] bByte = ms.ToArray();
                string DPI = txtDPI.Text;
                string Persona_Nombre1 = txtNombre1.Text;
                string Persona_Nombre2 = txtNombre2.Text;
                string Persona_Nombre3 = txtNombre3.Text;
                string Persona_Apellido1 = txtApelldo1.Text;
                string Persona_Apellido2 = txtApellido2.Text;
                string Persona_Apellido3 = txtApellido3.Text;
                string Persona_FechaNac = txtFechaNa.Text;
                string Persona_Direccion = txtDireccion.Text;
                string Persona_Telefono = txtTelefono.Text;
                string Persona_CentroID = txtCentro.Text;
                int Persona_MpioID = Convert.ToInt32(txtMpio.Text);

                

                SqlConnection con = new SqlConnection(@"Data Source=GABRIEL;Initial Catalog=Bd_ProyectoFinal;Integrated Security=True");
                con.Open();
                string query = "Insert into Tb_Personas (Persona_DPI, Persona_Nombre1, Persona_Nombre2, Persona_Nombre3, Persona_Apellido1, Persona_Apellido2, Persona_Apellido3, Persona_FechaNac, Persona_Direccion, Persona_Telefono, Persona_MpioID, Persona_CentroID, Persona_Foto, Persona_Firma) Values(@Persona_DPI, @Persona_Nombre1, @Persona_Nombre2, @Persona_Nombre3, @Persona_Apellido1, @Persona_Apellido2, @Persona_Apellido3, @Persona_FechaNac, @Persona_Direccion, @Persona_Telefono, @Persona_MpioID, @Persona_CentroID, @Persona_Foto, @Persona_Firma)";
                


                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@Persona_Foto", aByte);
                cmd.Parameters.AddWithValue("@Persona_DPI", DPI);
                cmd.Parameters.AddWithValue("@Persona_Nombre1", Persona_Nombre1);
                cmd.Parameters.AddWithValue("@Persona_Nombre2", Persona_Nombre2);
                cmd.Parameters.AddWithValue("@Persona_Nombre3", Persona_Nombre3);
                cmd.Parameters.AddWithValue("@Persona_Apellido1", Persona_Apellido1);
                cmd.Parameters.AddWithValue("@Persona_Apellido2", Persona_Apellido2);
                cmd.Parameters.AddWithValue("@Persona_Apellido3", Persona_Apellido3);
                cmd.Parameters.AddWithValue("@Persona_FechaNac", Persona_FechaNac);
                cmd.Parameters.AddWithValue("@Persona_Direccion", Persona_Direccion);
                cmd.Parameters.AddWithValue("@Persona_Telefono", Persona_Telefono);
                cmd.Parameters.AddWithValue("@Persona_MpioID", Persona_MpioID);
                cmd.Parameters.AddWithValue("@Persona_CentroID", Persona_CentroID);
                cmd.Parameters.AddWithValue("@Persona_Firma", bByte); 




                cmd.ExecuteNonQuery();

                MessageBox.Show("Persona Agregada!");

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        public void InsertarFoto()
        {
            
        }

        private void btnImg_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
