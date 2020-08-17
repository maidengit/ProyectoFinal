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
    public partial class ReporteCalificaciones : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=KIRITOPC\SQLEXPRESS;Initial Catalog=proyescuela;Integrated Security=True");


        public ReporteCalificaciones()
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


        public void cargarAlumno(String GradoID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select EstudianteID, Nombre from Estudiante where GradoID = @GradoID", con);
            cmd.Parameters.AddWithValue("GradoID", GradoID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["Nombre"] = "Selecciona un alumno";
            dt.Rows.InsertAt(dr, 0);
            con.Close();

            cbalumno.ValueMember = "GradoID";
            cbalumno.DisplayMember = "Nombre";
            cbalumno.DataSource = dt;
        }

        private void ReporteCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            MostarReporte mostrar = new MostarReporte();
            mostrar.nombre = cbalumno.Text;
            mostrar.grado = cbgrado.Text;
            mostrar.semestre = int.Parse(cbsemestre.Text);

            mostrar.ShowDialog();
        }

        private void cbgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgrado.SelectedValue.ToString() != null)
            {
                String GradoID = cbgrado.SelectedValue.ToString();
                cargarAlumno(GradoID);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
