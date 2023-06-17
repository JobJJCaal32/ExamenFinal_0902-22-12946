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

namespace Serie3_Ejercicio2
{
    public partial class Frm_Inicio : Form
    {
        ConexionBD conecxion = new ConexionBD();
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            conecxion.abrir();
            string cadena1 = "Insert Into Tabla_Productos([ID],[Codigo_Producto],[Nombre_Producto],[Categoria]) + " + "values('" + TxtID.Text + "','" + TxtCodigo.Text+ "','" + TxtNombre.Text+ "','" + TxtCategoria.Text+"',)";
            SqlCommand comando = new SqlCommand(cadena1, conecxion.Conecxion);
            conecxion.cerrar();

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            conecxion.abrir();
            string cadena = "SELECT * FROM Tabla_Productos";
            SqlCommand comando = new SqlCommand(cadena, conecxion.Conecxion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Tabla.DataSource = tabla;
            conecxion.cerrar(); 

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCategoria.Clear();
            TxtCodigo.Clear();
            TxtID.Clear();
            TxtNombre.Clear(); 
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}
