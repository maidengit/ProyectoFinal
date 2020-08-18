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
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        public void Datos()
        {
            SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            string sql = "SELECT  UsuarioNombre, Clave from Usuario where UsuarioNombre like @Usuario and Clave like @Password";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Menu pp = new Menu();
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    pp.Show();
                    this.Hide();
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
            //btnIngresar.Enabled = false;
            if (txtUsuario.Text.Equals("Usuario") || txtUsuario.Text.Trim().Length == 0 || txtPassword.Text.Equals("Contraseña") || txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Usuario y Contraseña vacíos. Ingrese Usuario y contraseña");
   
                return;
            }
            else if (txtUsuario.Text.Equals("Usuario") && !txtPassword.Text.Equals("Contraseña"))
            {
                MessageBox.Show("Ingrese un usuario");
                return;
            }
            else if (!txtUsuario.Text.Equals("Usuario") && txtPassword.Text.Equals("Contraseña"))
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }
            else
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                string sql = "SELECT e.Identidad, UsuarioNombre, Clave from Usuario as u inner join Empleado as e on u.EmpleadoID = e.EmpleadoID where UsuarioNombre like @Usuario and Clave like @Password";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Menu pp = new Menu();
                        pp.labelIDForm.Text = reader[0] as string;
                        pp.NombreForm.Text = reader[1] as string;
                        
                        MessageBox.Show("Bienvenido " + txtUsuario.Text);
                        pp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña o el usuario son incorrectos, intenta de nuevo");
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
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }
        
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                string sql = "SELECT UsuarioNombre, Clave from Usuario where UsuarioNombre like @Usuario and Clave like @Password";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Menu pp = new Menu();
                        MessageBox.Show("Bienvenido " + txtUsuario.Text);
                        pp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña o el usuario son incorrectos, intenta de nuevo");
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
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
                string sql = "SELECT UsuarioNombre, Clave from Usuario where UsuarioNombre like @Usuario and Clave like @Password";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                try
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Menu pp = new Menu();
                        MessageBox.Show("Bienvenido " + txtUsuario.Text);
                        pp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña o el usuario son incorrectos, intenta de nuevo");
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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
