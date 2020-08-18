using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class IngresoEmpleado : Form
    {
        public IngresoEmpleado()
        {
            InitializeComponent();
        }
        String civil=""; String depart = ""; Boolean actualizar = false;
        public IngresoEmpleado(String id, String nombre, String identidad, String fechanacimiento, String depid,
            String Direccion, String telefono, String email, String sexo, String estado, Boolean update)
        {
            InitializeComponent();
            txtdir.Text = Direccion;
            txtemail.Text = email;
            txtidentidad.Text = identidad;
            txtnombre.Text = nombre;
            txtid.Text = id;
            txttelefomo.Text = telefono;
            if (sexo == "M") rbm.Checked=true;
            if (sexo == "F") rbf.Checked = true;
            cbcivil.SelectedIndex = 0;
            dateTimePicker1.CustomFormat = fechanacimiento;
            /*txtsalario.Text = ;*/
            actualizar = update;
        }
        conexionbdasignaturayempleadoadmin link = new conexionbdasignaturayempleadoadmin();
        private void IngresoEmpleado_Load(object sender, EventArgs e)
        {
            cbdepartamento.DataSource = link.llenadoDepartamento();
            cbdepartamento.DisplayMember = "nombre";

            if (civil !="")
            {
                cbcivil.SelectedItem = civil;
                cbdepartamento.SelectedItem = depart;
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            String sexo = "";
            if (rbm.Checked == true) sexo = "m";
            if (rbf.Checked == true) sexo = "f";
            if (sexo == "") MessageBox.Show("Por favor escoja su sexo");
            if ( actualizar == false)
            {
                if (txtnombre.Text != "" && txtidentidad.Text != "" && txttelefomo.Text != "" && txtemail.Text != "")
                {
                    String id = link.empleadoID();
                    txtid.Text = id;
                    String nombre = txtnombre.Text;
                    String identidad = txtidentidad.Text;
                    String fechanacimiento = dateTimePicker1.Value.ToString();
                    String depid = (cbdepartamento.SelectedIndex + 1).ToString();
                    String Direccion = txtdir.Text;
                    String telefono = txttelefomo.Text;
                    String email = txtemail.Text;
                    String estado = cbcivil.SelectedItem.ToString();
                    link.Insertarempleado(id, nombre, identidad, fechanacimiento, depid, Direccion, telefono, email, sexo, estado);
                    MessageBox.Show("Registro exitoso, empleado registrado!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Por favor llene todas las casillas!");
                }
            }
            else
            {
                if (txtnombre.Text != "" && txtidentidad.Text != "" && txttelefomo.Text != "" && txtemail.Text != "")
                {
                    String id = txtid.Text;
                    String nombre = txtnombre.Text;
                    String identidad = txtidentidad.Text;
                    String fechanacimiento = dateTimePicker1.Value.ToString();
                    String depid = (cbdepartamento.SelectedIndex + 1).ToString();
                    String Direccion = txtdir.Text;
                    String telefono = txttelefomo.Text;
                    String email = txtemail.Text;
                    String estado = cbcivil.SelectedItem.ToString();
                    link.UpdateEmpleado(id, nombre, identidad, fechanacimiento, depid, Direccion, telefono, email, sexo, estado);
                    MessageBox.Show("Registro exitoso, empleado registrado!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Por favor llene todas las casillas!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
