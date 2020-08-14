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
    public partial class ConsultaEmpleadoAdministrativo : Form
    {
        public ConsultaEmpleadoAdministrativo()
        {
            InitializeComponent();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
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
    }
}
