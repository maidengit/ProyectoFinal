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
    public partial class IngresoAsignaturaAdministrativo : Form
    {
        public IngresoAsignaturaAdministrativo()
        {
            InitializeComponent();
            
        }
        public IngresoAsignaturaAdministrativo(String nombre, String empleado, String grado, String asignaturaid)
        {
            InitializeComponent();
            txtnombre.Text = nombre;
            cbdocenteid.SelectedItem = empleado;
            cbgradoid.SelectedItem = grado;
            txtid.Text = asignaturaid;
        }
        conexionbdasignaturayempleadoadmin link = new conexionbdasignaturayempleadoadmin();
        String centinela = "N";
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (centinela == "N")
            {
                if (txtnombre.Text != "" && cbdocenteid.Text != "" && cbgradoid.Text != "")
                {
                    decimal x = spsemestre.Value;
                    String h = x.ToString();

                    if (link.InsertarAsignatura(link.asignaturaID(), txtnombre.Text, (cbdocenteid.SelectedIndex + 1).ToString(),
                        (cbgradoid.SelectedIndex + 1).ToString(), h))
                    {
                        MessageBox.Show("Se ha insertado la Asignatura con Exito!");
                        this.Dispose();
                    }
                    else MessageBox.Show("No se inserto la Asignatura");
                }
                else MessageBox.Show("Por favor llenar todos los campos!");
            }
            if(centinela == "A")
            {
                if (txtnombre.Text != "" && cbdocenteid.Text != "" && cbgradoid.Text != "")
                {
                    decimal x = spsemestre.Value;
                    String h = x.ToString();

                    if (link.UpdateAsignatura(txtid.Text, txtnombre.Text, (cbdocenteid.SelectedIndex + 1).ToString(), 
                        (cbgradoid.SelectedIndex + 1).ToString(), h))
                    {
                        MessageBox.Show("Se ha Actualizado la Asignatura con Exito!");
                        this.Dispose();
                    }
                    else MessageBox.Show("No se Actualizo la Asignatura");
                }
                else MessageBox.Show("Por favor llenar todos los campos!");
            }

        }

        private void IngresoAsignaturaAdministrativo_Load(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtid.Text = link.asignaturaID();

                cbgradoid.DataSource = link.llenadoGrado();
                cbgradoid.DisplayMember = "Curso";

                cbdocenteid.DataSource = link.llenadoDocente();
                cbdocenteid.DisplayMember = "Nombre";
            }
            else
            {
                cbgradoid.DataSource = link.llenadoGrado();
                cbgradoid.DisplayMember = "Curso";

                cbdocenteid.DataSource = link.llenadoDocente();
                cbdocenteid.DisplayMember = "Nombre";
                centinela = "A";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
