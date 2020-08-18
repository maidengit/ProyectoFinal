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

        public ConsultaUsuarios()
        {
            InitializeComponent();
            gridUsuario.RowHeadersVisible = false;
            gridUsuario.ReadOnly = true;
            gridUsuario.AllowUserToAddRows = false;
            gridUsuario.AllowUserToDeleteRows = false;
            gridUsuario.AllowUserToResizeColumns = false;
            gridUsuario.AllowUserToOrderColumns = false;
            gridUsuario.AllowUserToResizeRows = false;
            for (int i = 0; i < gridUsuario.Columns.Count; i++)
            {
                gridUsuario.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            filtrado.SelectedIndex = 0;
            //Le doy ancho a las columnas
            //gridUsuario.Columns[0].Width = gridUsuario.Width * 10/100;
            //gridUsuario.Columns[1].Width = gridUsuario.Width * 20/100;
            //gridUsuario.Columns[2].Width = gridUsuario.Width * 20/100;
            //gridUsuario.Columns[3].Width = gridUsuario.Width * 10/100;
            
            txtFiltroUsuario.Focus();
        }

        private void CargarDatos()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadena);
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

        DataTable dt = new DataTable();

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ru = new RegistroUsuarios();
            ru.ShowDialog();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
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
            this.Close();
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
            /*try
            {
                gridUsuario.Columns[0].Width = gridUsuario.Width * 20 / 100;
                gridUsuario.Columns[1].Width = gridUsuario.Width * 30 / 100;
                gridUsuario.Columns[2].Width = gridUsuario.Width * 30 / 100;
                gridUsuario.Columns[3].Width = gridUsuario.Width * 20 / 100;
            }
            catch (Exception ex)
            {
                
            }*/
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.gridUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Tiene que elgir un Usuario:");
            }
            else
            {
                string estado;
                //nombre = this.gridUsuario.CurrentRow.Cells[0].Value.ToString();
                EditarUsuario eu = new EditarUsuario();
                eu.txtNombreEmpleado.Text = gridUsuario.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
                eu.txtUsuario.Text = gridUsuario.CurrentRow.Cells["UsuarioNombre"].Value.ToString();
                eu.txtDepartamento.Text = gridUsuario.CurrentRow.Cells["Departamento"].Value.ToString();
                estado = gridUsuario.CurrentRow.Cells["Departamento"].Value.ToString();
                if (estado.Equals("A"))
                {
                    eu.radioActivo.Checked = true;
                }
                else
                {
                    eu.radioInactivo.Checked = true;
                }
                
                eu.Show();
            }
        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            cambioContrasenia cc = new cambioContrasenia();
            cc.ShowDialog();
        }
    }
}
