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
        conexionbdasignaturayempleadoadmin asignatura = new conexionbdasignaturayempleadoadmin();
        String nombre = null;
        String empleado = null;
        String grado = null;
        String id = null;
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
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IngresoAsignaturaAdministrativo link = new IngresoAsignaturaAdministrativo();
            link.ShowDialog();
        }

        private void ConsultaAsignaturaAdministrativa_Load(object sender, EventArgs e)
        {
            Tabla.DataSource = asignatura.mostrarDatos();
            cbGradoAsignatura.DataSource = asignatura.llenadoGrado();
            cbGradoAsignatura.DisplayMember = "Curso";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombre == null)
            {
                MessageBox.Show("Por favor selecciona una filla para modificar");
            }
            else
            {
                DialogResult d =
                MessageBox.Show("Eliminar Asignatura","Esta seguro de eliminar esta asignatura?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (asignatura.EliminarAsignatura(id))
                    {
                        MessageBox.Show("Se ha eliminado exitosamente!");
                        Tabla.DataSource = asignatura.mostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha eliminado la asignatura");
                    }
                } else if (d == DialogResult.No)
                {
                    MessageBox.Show("No se ha eliminado la asignatura");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtAsignaturaDocente.Text != "") Tabla.DataSource = asignatura.BuscarDocente(txtAsignaturaDocente.Text);
            else Tabla.DataSource = asignatura.mostrarDatos();
        }

        private void txtAsignaturaNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtAsignaturaNombre.Text != "") Tabla.DataSource = asignatura.BuscarAsignatura(txtAsignaturaNombre.Text);
            else Tabla.DataSource = asignatura.mostrarDatos();
        }

        private void cbGradoAsignatura_TextChanged(object sender, EventArgs e)
        {
            if (cbGradoAsignatura.Text != "") Tabla.DataSource = asignatura.BuscarGrado(cbGradoAsignatura.Text);
            else Tabla.DataSource = asignatura.mostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (nombre == null)
            {
                MessageBox.Show("Por favor selecciona una filla para modificar");
            }
            else
            {
                IngresoAsignaturaAdministrativo link = new IngresoAsignaturaAdministrativo(nombre, empleado, grado, id);
                link.ShowDialog();
            }
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Fila = Tabla.Rows[e.RowIndex];
            nombre = Convert.ToString(Fila.Cells[1].Value);
            empleado = Convert.ToString(Fila.Cells[2].Value);
            grado = Convert.ToString(Fila.Cells[3].Value);
            id = Convert.ToString(Fila.Cells[0].Value);

        }
    }
}
