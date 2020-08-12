using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class RegistroUsuarios : Form
    {
        bool validacionUsuario = false;
        bool validacionContrasenia = false;
        bool validacionConfirmacionContrasenia = false;
        bool validacionEmpleadoID = false;

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
            if (!validacionEmpleadoID)
            {
                MessageBox.Show("EmpleadoID es incorrecto");
                txtEmpleadoID.Focus();
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
                MessageBox.Show("Datos almacenados satisfactoriamente");
                this.Dispose();
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
                errorProviderConfirmarContrasenia.SetError(txtConfirmarContrasenia, "Contraseña no concuerda");
            }
            else
            {
                errorProviderConfirmarContrasenia.Clear();
                validacionConfirmacionContrasenia = true;
            }
        }

        private void txtEmpleadoID_Validated(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            String sql = "Select EmpleadoID, Nombre from Empleado where EmpleadoID like '%" + txtEmpleadoID.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                txtNombreEmpleado.Text = "";
                if(reader.Read())
                {
                    txtNombreEmpleado.Text = reader["Nombre"] as string;
                }
                else
                {
                    errorProviderEmpleadoID.SetError(txtEmpleadoID, "EmpleadoID no está registrado");
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

            if(txtEmpleadoID.Text.Trim().Length == 0)
            {
                errorProviderEmpleadoID.SetError(txtEmpleadoID, "Ingrese el empleadoID");
                txtNombreEmpleado.Text = "";
            }
            else
            {
                errorProviderEmpleadoID.Clear();
                validacionEmpleadoID = true;
            }
        }
    }
}
