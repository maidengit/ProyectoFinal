using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class RegistroUsuarios : Form
    {
        SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);

        bool validacionUsuario = false;
        bool validacionContrasenia = false;
        bool validacionConfirmacionContrasenia = false;
        bool validacionIdentidad = false;

        string Estado = "Activo";
        string empleadoID;

        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validacionIdentidad)
            {
                MessageBox.Show("La identidad del empleado es incorrecta");
                txtIdentidad.Focus();
                return;
            }
            else if (!validacionUsuario)
            {
                MessageBox.Show("Nombre de usuario es incorrecto");
                txtNombreUsuario.Focus();
                return;
            }
            else if (!validacionContrasenia)
            {
                MessageBox.Show("Contraseña es incorrectas");
                txtContrasenia.Focus();
                return;
            }
            else if(!validacionConfirmacionContrasenia)
            {
                MessageBox.Show("La confiramción de la contraseña no es correcta");
                txtConfirmarContrasenia.Focus();
                return;
            }
            else
            {
                /*SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                string sql = "exec spInsertarUsuarios @empleadoid, @contrasenia, @estado, @usuario";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", txtNombreUsuario.Text);
                cmd.Parameters.AddWithValue("@contrasenia", txtContrasenia.Text);
                cmd.Parameters.AddWithValue("@empleadoid", empleadoID);

                if (String.IsNullOrEmpty(Estado))
                {
                    cmd.Parameters.AddWithValue("@estado", DBNull.Value);
                }
                else
                    cmd.Parameters.AddWithValue("@estado", Estado);
                ////cmd.Parameters.AddWithValue("@empleadoID", EmpleadoID);
                ////cmd.Parameters.AddWithValue("@estado", Estado);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos almacenados satisfactoriamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }
                
                this.Dispose();*/

                MessageBox.Show("En construcción");
            }
            
        }

        private void txtNombreUsuario_Validated(object sender, EventArgs e)
        {

            if (txtNombreUsuario.Text.Trim().Length == 0)
            {
                errorProviderUsuario.SetError(txtNombreUsuario, "Ingrese nombre de usuario");
                
            }
            else
            {
                errorProviderUsuario.Clear();
                validacionUsuario = true;
            }
        }

        private void txtContrasenia_Validated(object sender, EventArgs e)
        {
            if(txtContrasenia.Text.Trim().Length == 0)
            {
                errorProviderContrasenia.SetError(txtContrasenia, "Ingrese Contrasenña");
            }
            else
            {
                errorProviderContrasenia.Clear();
                validacionContrasenia = true;
            }
        }

        private void txtConfirmarContrasenia_Validated(object sender, EventArgs e)
        {
            if (txtConfirmarContrasenia.Text.Trim().Length == 0)
            {
                errorProviderConfirmarContrasenia.SetError(txtConfirmarContrasenia, "Ingrese Contrasenña");
            }
            else if(txtConfirmarContrasenia.Text != txtContrasenia.Text)
            {
                errorProviderConfirmarContrasenia.SetError(txtConfirmarContrasenia, "Contraseña no coincide");
            }
            else
            {
                errorProviderConfirmarContrasenia.Clear();
                validacionConfirmacionContrasenia = true;
            }
        }

        private void txtIdentidad_Validated(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            string sql = "select e.Nombre, d.Nombre as Departamento, e.EmpleadoID from Empleado as e inner join Departamento as d on e.DepartamentoID = d.DepartamentoID where e.Identidad = @identidad";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@identidad", txtIdentidad.Text);
            cmd.Parameters.AddWithValue("@departamento", txtDepartamento.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNombreEmpleado.Text = reader[0] as string;
                        txtDepartamento.Text = reader[1] as string;
                        empleadoID = reader[2] as string;

                    }

                }
                else
                {
                    errorProviderEmpleadoID.SetError(txtIdentidad, "Identidad no está registrada");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }

            if(txtIdentidad.Text.Trim().Length == 0)
            {
                errorProviderEmpleadoID.SetError(txtIdentidad, "Ingrese el empleadoID");
                txtNombreEmpleado.Text = "";
            }
            else
            {
                errorProviderEmpleadoID.Clear();
                validacionIdentidad = true;
            }
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Restaurarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizarpic.Visible = true;
            Restaurarpic.Visible = false;
        }
    }
}
