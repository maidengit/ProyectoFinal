using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            PantallaPrincipal Pp = new PantallaPrincipal();
            Pp.Show();
            this.Hide();
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

        
    }
}
