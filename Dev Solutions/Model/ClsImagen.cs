using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Dev_Solutions.Model
{
    public class ClsImagen
    {
        class ConsultarImagen
        {
            SqlConnection con = new SqlConnection("Data Source=GABRIEL;Initial Catalog=Bd_ProyectoFinal;Integrated Security=True");

            public bool InsertarImagen(string nombre, PictureBox pb)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Tb_Personas (Persona_Foto, Persona_Firma) Values (@Foto, @Firma)", con);
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters.Add("@Firma", SqlDbType.Image);

                MemoryStream ms = new MemoryStream();

                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Foto"].Value = ms.GetBuffer();

                int resultado = cmd.ExecuteNonQuery();

                con.Close();

                if (resultado > 0) return true;
                else return false;
            }

            public bool ActualizarImagen(string nombre, PictureBox pb)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Into Tb_Personas (Persona_Foto, Persona_Firma) Values (@Foto, @Firma)", con);
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                cmd.Parameters.Add("@Firma", SqlDbType.Image);

                MemoryStream ms = new MemoryStream();

                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Foto"].Value = ms.GetBuffer();

                int resultado = cmd.ExecuteNonQuery();

                con.Close();

                if (resultado > 0) return true;
                else return false;
            }
        }
    }
}
