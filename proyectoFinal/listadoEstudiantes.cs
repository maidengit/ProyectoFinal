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
    public partial class listadoEstudiantes : Form
    {
        public listadoEstudiantes()
        {
            InitializeComponent();
            load();
            grid.RowHeadersVisible = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeRows = false;
            //evitar que se le pueda hacer SORT a todas las columnas
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            comboBox.SelectedIndex = 0;
            //Le doy ancho a las columnas
            grid.Columns[0].Width = grid.Width * 4 / 100;
            grid.Columns[1].Width = grid.Width * 26 / 100;
            grid.Columns[2].Width = grid.Width * 13 / 100;
            grid.Columns[3].Width = grid.Width * 5 / 100;
            grid.Columns[4].HeaderText = "Tipo \nSangre";
            grid.Columns[4].Width = grid.Width * 7 / 100;
            grid.Columns[5].Visible = false;
            grid.Columns[6].Width = grid.Width * 5 / 100;
            grid.Columns[7].Width = grid.Width * 29 / 100;
            grid.Columns[8].Width = grid.Width * 10 / 100;
            filtro.Focus();
        }
        private void load()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Resources.cadenaConexion);
                //String Query = "SELECT es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso FROM empleado e inner join Grado g on e.EmpleadoID = g.EmpleadoID inner join Estudiante es on g.GradoID = es.GradoID where es.estado = 'A'and e.Identidad='0501312364521' group by e.Identidad, es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso order by Nombre";
                String Query = "SELECT es.estudianteID[ID] , es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso, dbo.fnEdad(es.EstudianteID) [Edad], dbo.fnNombreTutor(EstudianteID)[Tutor], dbo.fnTelefonoTutor(EstudianteID)[Telefono] FROM empleado e    inner join Grado g on e.EmpleadoID = g.EmpleadoID    inner join Estudiante es on g.GradoID = es.GradoID where es.estado = 'A'    and e.Identidad = '0501312364521'group by    es.EstudianteID, e.Identidad, es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso,  es.Fecha order by Nombre";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                da.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dt = new DataTable();
        private void MenuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizarpic.Visible = false;
            Restaurarpic.Visible = true;
        }

        private void Minimizarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizarpic.Visible = true;
            Restaurarpic.Visible = false;
        }

        private void cbAignatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif",14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Empleados",myfont,mybrush,0,0);
        }

        private void menupic_Click(object sender, EventArgs e)
        {
            //Menu link = new Menu();
            //link.Show();
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IngresoEmpleado link = new IngresoEmpleado();
            link.Show();
        }

        private void cbAignatura_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            if (comboBox.SelectedIndex != 0)
            {
                dt.DefaultView.RowFilter = "Curso like '%" + comboBox.Text + "'";
                filtro.Text = "";
            }
        }

        private void EmpleadoWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (filtro.Text.Trim().Length == 0)
            {
                if (comboBox.SelectedIndex != 0)
                {
                    dt.DefaultView.RowFilter = "Curso like '%" + comboBox.Text + "'"; ;
                    return;
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
            else
            {
                if (comboBox.SelectedIndex != 0)
                {
                    dt.DefaultView.RowFilter = "Nombre like '%" + filtro.Text + "%' and Curso like '%" + comboBox.Text + "'"; ;
                    return;
                }
                else
                {
                    dt.DefaultView.RowFilter = "Nombre like '%" + filtro.Text + "%'";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            load();
            filtro.Text = "";
        }
    }
}
