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
    public partial class cambioContrasenia : Form
    {
        public cambioContrasenia()
        {
            InitializeComponent();
        }

        private void txtContraseniaNueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void txxtContraseniaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            string sql = "select UsuarioID, Clave from Usuario where Clave = @contraseniaActual";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@contraseniaActual", txtContraseniaActual.Text);
            
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var usuario = reader[0] as string;

                        if (txtContraseniaNueva.Text == txtConfirmarContrasenia.Text)
                        {
                            SqlConnection con = new SqlConnection(Properties.Resources.cadenaConexion);
                            string query = "Update Usuario set Clave = @contraseniaNueva where UsuarioID = @usuario"; // where UsuarioID = @usuario" ;
                            
                            
                            SqlCommand cmd1 = new SqlCommand(query, con);
                            cmd1.Parameters.AddWithValue("@contraseniaNueva", txtContraseniaNueva.Text);
                            if (String.IsNullOrEmpty(usuario))
                            {
                                cmd1.Parameters.AddWithValue("@usuario", DBNull.Value);
                            }
                            else
                                cmd1.Parameters.AddWithValue("@usuario", usuario);

                            try
                            {
                                cmd1.Connection.Open();
                                cmd1.ExecuteNonQuery();
                                SqlDataReader reader1 = cmd1.ExecuteReader();
                                
                                MessageBox.Show("Contraseña actualizada");
                                cmd1.Connection.Close();
                                this.Close();
                                return;
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }   
                        else
                        {
                            errorProvider1.SetError(txtConfirmarContrasenia, "Contraseña no coincide");
                            return;
                        }
                    }
                }
                else
                {
                    //errorProviderEmpleadoID.SetError(txtIdentidad, "EmpleadoID no está registrado");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
