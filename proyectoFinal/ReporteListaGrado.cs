using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoFinal
{
    public partial class ReporteListaGrado : Form
    {


        SqlConnection con = new SqlConnection(Properties.Resources.cadena);

        public ReporteListaGrado()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select GradoID, Curso  from Grado", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Curso"] = "Selecciona un grado";
            dt.Rows.InsertAt(fila, 0);

            cbgrado.ValueMember = "GradoID";
            cbgrado.DisplayMember = "Curso";
            cbgrado.DataSource = dt;

        }

        private void ReporteListaGrado_Load(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            MostarReporte2 m = new MostarReporte2();
            m.grado = cbgrado.Text;

            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
