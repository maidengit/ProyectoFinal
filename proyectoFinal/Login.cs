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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Resources.cadenaConexion);
            string sql = "SELECT UsuarioNombre, Clave from Usuario where UsuarioNombre like @Usuario and Clave like @Password ";
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
                    MessageBox.Show("Usuario o Contraseña son incorrecto, por favor intenta de nuevo");
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
                txtPassword.UseSystemPasswordChar = true;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu Pp = new Menu();
            Pp.Show();
            this.Hide();
        }
    }
}
