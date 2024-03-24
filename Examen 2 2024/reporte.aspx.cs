using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Examen_2_2024
{
    public partial class reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CalcularReporte();
            }
        }

        protected void CalcularReporte()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Calcular cantidad de encuestas realizadas
                SqlCommand cmdEncuestas = new SqlCommand("SELECT COUNT(*) FROM pruebas", connection);
                int cantidadEncuestas = (int)cmdEncuestas.ExecuteScalar();
                lblCantidadEncuestas.Text = cantidadEncuestas.ToString();

                // Calcular cantidad de personas con carro propio
                SqlCommand cmdCarroPropio = new SqlCommand("SELECT COUNT(*) FROM pruebas WHERE Carro = 'Si'", connection);
                int cantidadCarroPropio = (int)cmdCarroPropio.ExecuteScalar();
                lblCantidadCarroPropio.Text = cantidadCarroPropio.ToString();

                // Calcular cantidad de personas sin carro propio
                int cantidadSinCarro = cantidadEncuestas - cantidadCarroPropio;
                lblCantidadSinCarro.Text = cantidadSinCarro.ToString();

                connection.Close();
            }
        }
    }
}