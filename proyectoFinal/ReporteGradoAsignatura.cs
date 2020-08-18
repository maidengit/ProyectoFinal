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
    public partial class ReporteGradoAsignatura : Form
    {
        SqlConnection con = new SqlConnection(Properties.Resources.cadena);


        public ReporteGradoAsignatura()
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

        public void cargarAsignatura(String GradoID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select AsignaturaID, Nombre from Asignatura where GradoID = @GradoID", con);
            cmd.Parameters.AddWithValue("GradoID", GradoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["Nombre"] = "Selecciona una asignatura";
            dt.Rows.InsertAt(dr, 0);
            con.Close();

            cbalumno.ValueMember = "GradoID";
            cbalumno.DisplayMember = "Nombre";
            cbalumno.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgrado.SelectedValue.ToString() != null)
            {
                String GradoID = cbgrado.SelectedValue.ToString();
                cargarAsignatura(GradoID);

            }
        }

        private void ReporteGradoAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            MostarReporte3 mostrar = new MostarReporte3();
            mostrar.asignatura = cbalumno.Text;
            mostrar.grado = cbgrado.Text;
            mostrar.semestre = int.Parse(cbsemestre.Text);

            mostrar.ShowDialog();
        }
    }
}
