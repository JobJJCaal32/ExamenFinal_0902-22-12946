using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Serie3_Ejercicio2
{
    internal class ConexionBD
    {
        string cadena = "Data Source = DESKTOP-94LRUI8; Initial Catalog = Serie3; Integrated Security = true";
        public SqlConnection Conecxion = new SqlConnection();

        public ConexionBD()
        {
            Conecxion.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                Conecxion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se ha pidido conectar a la base de datos " + ex.Message);
            }
        }
        public void cerrar()
        {
            Conecxion.Close();
        }

    }
}
