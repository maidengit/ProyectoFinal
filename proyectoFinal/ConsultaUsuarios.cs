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
        SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
        DataTable dt = new DataTable();

        private void CargarDatos()
        {
            try
            {
                string sql = "select u.UsuarioNombre, e.Nombre as NombreEmpleado, d.Nombre as Departamento, u.Estado from Usuario as u inner join Empleado as e on u.EmpleadoID = e.EmpleadoID inner join Departamento as d on e.DepartamentoID = d.DepartamentoID";
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
                string sql = "select u.UsuarioNombre, e.Nombre as NombreEmpleado, d.Nombre as 'Departamento', u.Estado from Usuario as u inner join Empleado as e on u.EmpleadoID = e.EmpleadoID inner join Departamento as d on e.DepartamentoID = d.DepartamentoID";
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
            dt.Clear();
            CargarDatos();
            txtFiltroUsuario.Text = "";
            filtrado.Text = "";
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

            if (txtFiltroUsuario.Text.Trim().Length == 0)
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            if (filtrado.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "UsuarioNombre like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = "NombreEmpleado like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = "Departamento like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 3)
            {
                dt.DefaultView.RowFilter = "Estado like '%" + txtFiltroUsuario.Text + "%'";
            }
            
        }

        private void filtrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFiltroUsuario.Text.Trim().Length == 0)
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            if (filtrado.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "UsuarioNombre like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = "NombreEmpleado like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = "Departamento like '%" + txtFiltroUsuario.Text + "%'";
            }

            if (filtrado.SelectedIndex == 3)
            {
                dt.DefaultView.RowFilter = "Estado like '%" + txtFiltroUsuario.Text + "%'";
            }
        }

        private void ConsultaUsuarios_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                
                gridUsuario.Columns[0].Width = 100;   
                
                gridUsuario.Columns[1].Width = gridUsuario.Width * 50 / 100; 
                
                gridUsuario.Columns[2].Width = gridUsuario.Width * 50 / 100;

                gridUsuario.Columns[3].Width = gridUsuario.Width * 50 / 100;
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
