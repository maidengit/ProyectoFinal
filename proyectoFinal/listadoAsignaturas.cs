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
    public partial class listadoAsignaturas : Form
    {
        public listadoAsignaturas()
        {
            InitializeComponent();
            load();

            grid1.RowHeadersVisible = false;
            //evitar poder agregar nuevas filas y poder escribir en el GRID
            grid1.ReadOnly = true;
            grid1.AllowUserToAddRows = false;
            grid1.AllowUserToDeleteRows = false;
            grid1.AllowUserToResizeColumns = false;
            grid1.AllowUserToOrderColumns = false;
            grid1.AllowUserToResizeRows = false;
            comboBox1.SelectedIndex = 0;
            //mandar a llamar el evento de cambio de tamaño de la ventana

            //evitar que se le pueda hacer SORT a todas las columnas
            for (int i = 0; i < grid1.Columns.Count; i++)
            {
                grid1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            comboBox1.SelectedIndex = 0;
            filtro.Focus();
        }
        DataTable dt = new DataTable();
        private void load()
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Resources.cadena);
                //String Query = "SELECT es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso FROM empleado e inner join Grado g on e.EmpleadoID = g.EmpleadoID inner join Estudiante es on g.GradoID = es.GradoID where es.estado = 'A'and e.Identidad='0501312364521' group by e.Identidad, es.Nombre, es.Identidad, es.Sexo, es.TipoDeSangre, g.Curso order by Nombre";
                String Query = "SELECT a.Nombre, a.Semestre, g.Curso FROM Departamento d inner join Empleado e on d.DepartamentoID = e.DepartamentoID inner join Asignatura a on a.EmpleadoID = e.EmpleadoID inner join Grado g on a.GradoID = g.GradoID where  e.Identidad = '0501199908556' and d.DepartamentoID=1 group by a.Nombre, a.Semestre, g.Curso";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                da.Fill(dt);
                grid1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
            if (comboBox1.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "";
                return;
            }
            if (comboBox1.SelectedIndex != 0)
            {
                dt.DefaultView.RowFilter = "Curso like '%" + comboBox1.Text + "'";
                filtro.Text = "";
            }
        }

        private void EmpleadoWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            if (filtro.Text.Trim().Length == 0)
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    dt.DefaultView.RowFilter = "Curso like '%" + comboBox1.Text + "'"; ;
                    return;
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
            else
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    dt.DefaultView.RowFilter = "Nombre like '%" + filtro.Text + "%' and Curso like '%" + comboBox1.Text + "'"; ;
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
