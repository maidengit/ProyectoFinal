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

namespace proyectoFinal
{
    public partial class ConsultaUsuarios : Form
    {
        DataTable dt = new DataTable();

        private void CargarDatos()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                //String Query = "SELECT es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso FROM empleado e inner join Grado g on e.EmpleadoID = g.EmpleadoID inner join Estudiante es on g.GradoID = es.GradoID where es.estado = 'A'and e.Identidad='0501312364521' group by e.Identidad, es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso order by Nombre";
                String sql = "SELECT a.Nombre, a.Semestre, g.Curso FROM Departamento d inner join Empleado e on d.DepartamentoID = e.DepartamentoID inner join Asignatura a on a.EmpleadoID = e.EmpleadoID inner join Grado g on a.GradoID = g.GradoID where e.Identidad = '1943199400094' group by a.Nombre, a.Semestre, g.Curso";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                da.Fill(dt);
                gridUsuario.DataSource = dt;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ru = new RegistroUsuarios();
            ru.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                //String Query = "SELECT es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso FROM empleado e inner join Grado g on e.EmpleadoID = g.EmpleadoID inner join Estudiante es on g.GradoID = es.GradoID where es.estado = 'A'and e.Identidad='0501312364521' group by e.Identidad, es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso order by Nombre";
                string sql = "SELECT a.Nombre, a.Semestre, g.Curso FROM Departamento d inner join Empleado e on d.DepartamentoID = e.DepartamentoID inner join Asignatura a on a.EmpleadoID = e.EmpleadoID inner join Grado g on a.GradoID = g.GradoID where e.Identidad = '1943199400094' group by a.Nombre, a.Semestre, g.Curso";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                da.Fill(dt);
                gridUsuario.DataSource = dt;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Restaurarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizarpic.Visible = true;
            Restaurarpic.Visible = false;
        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFiltroUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
