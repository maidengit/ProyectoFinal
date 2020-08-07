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

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
