using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_2_2024
{
    public partial class encuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(tNombre.Text) || string.IsNullOrWhiteSpace(tApellido.Text) || string.IsNullOrWhiteSpace(tEdad.Text) || string.IsNullOrWhiteSpace(tCorreo.Text) || rbCarro.SelectedValue == "")
            {
                // Mostrar mensaje de error si algún campo está vacío
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Todos los campos son obligatorios. Por favor, llene todos los campos.');", true);
                return;
            }

            // Validar que la edad esté entre 18 y 50 años
            if (!int.TryParse(tEdad.Text, out int edad) || edad < 18 || edad > 50)
            {
                // Mostrar mensaje de error si la edad no está dentro del rango permitido
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La edad debe estar entre 18 y 50 años.');", true);
                return;
            }

            // Obtener la selección del usuario en el control de radio
            string tieneCarro = rbCarro.SelectedValue;

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO pruebas (Nombre, Apellido, Edad, Correo, Carro) VALUES (@Nombre, @Apellido, @Edad, @Correo, @Carro)", conexion);
            comando.Parameters.AddWithValue("@Nombre", tNombre.Text);
            comando.Parameters.AddWithValue("@Apellido", tApellido.Text);
            comando.Parameters.AddWithValue("@Edad", tEdad.Text);
            comando.Parameters.AddWithValue("@Correo", tCorreo.Text);
            comando.Parameters.AddWithValue("@Carro", tieneCarro);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }


        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM pruebas", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind(); // refrescar la tabla
                        }
                    }
                }
            }
        }

        protected void Bborrar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE pruebas WHERE nombre = '" + tNombre.Text + "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        
    }
}