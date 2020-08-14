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
    public partial class ConsultaAsignaturaAdministrativa : Form
    {
        public ConsultaAsignaturaAdministrativa()
        {
            InitializeComponent();
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

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Microsoft Sans Serif", 14);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Asignaturas", myfont, mybrush, 0, 0);
        }

        private void menupic_Click(object sender, EventArgs e)
        {
            Menu link = new Menu();
            link.Show();
            this.Dispose();
        }
    }
}
