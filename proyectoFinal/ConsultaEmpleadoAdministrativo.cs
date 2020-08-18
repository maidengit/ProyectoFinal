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
        conexionbdasignaturayempleadoadmin link = new conexionbdasignaturayempleadoadmin();
        String id; String nombre; String identidad; String fechanacimiento; String depid;
        String Direccion; String telefono; String email; String sexo; String estado;
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

        private void ConsultaEmpleadoAdministrativo_Load(object sender, EventArgs e)
        {
            Tabla.DataSource = link.mostrarDatosEmpleados();
            cbDepartamento.DataSource = link.llenadoDepartamento();
            cbDepartamento.DisplayMember = "nombre";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IngresoEmpleado jj = new IngresoEmpleado();
            jj.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (nombre == null)
            {
                MessageBox.Show("Por favor selecciona una filla para modificar");
            }
            else
            {
                IngresoEmpleado jj = new IngresoEmpleado(id, nombre, identidad, fechanacimiento, depid,
                        Direccion,telefono,email,sexo,estado, true);
                jj.ShowDialog();
            }
        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Fila = Tabla.Rows[e.RowIndex];
            id = Convert.ToString(Fila.Cells[0].Value);
            nombre = Convert.ToString(Fila.Cells[1].Value);
            identidad = Convert.ToString(Fila.Cells[2].Value);
            fechanacimiento = Convert.ToString(Fila.Cells[3].Value);
            depid = Convert.ToString(Fila.Cells[4].Value);
            /*Direccion = Convert.ToString(Fila.Cells[5].Value);*/
            telefono = Convert.ToString(Fila.Cells[5].Value);
            email = Convert.ToString(Fila.Cells[6].Value);
            /*sexo = Convert.ToString(Fila.Cells[7].Value);*/
            /*estado = Convert.ToString(Fila.Cells[9].Value);*/

            /*String id; String nombre; String identidad; String fechanacimiento; String depid;
            String Direccion; String telefono; String email; String sexo; String estado;*/

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (txtNombre.Text != "") Tabla.DataSource = link.BuscarEmpleado(txtNombre.Text);
                else Tabla.DataSource = link.mostrarDatos3();
            }
        }

        private void cbDepartamento_TextChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.Text != "") Tabla.DataSource = link.BuscarEmpleadoporDepartamento(cbDepartamento.Text);
            else Tabla.DataSource = link.mostrarDatos3();
        }
    }
}
