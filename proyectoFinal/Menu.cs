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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnListadoEstudiantes_Click(object sender, EventArgs e)
        {
            listadoEstudiantes link = new listadoEstudiantes();
            //link.MdiParent = this;
            link.Visible = true;
            this.Visible = false;
        }

        private void btnListadoAsignaturas_Click(object sender, EventArgs e)
        {
            listadoAsignaturas link = new listadoAsignaturas();
            //link.MdiParent = this;
            link.Show();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            MantenimientoCalificaciones link = new MantenimientoCalificaciones();
            link.MdiParent = this;
            link.Show();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void btnTutor_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ConsultaEmpleadoAdministrativo link = new ConsultaEmpleadoAdministrativo();
            link.MdiParent = this;
            link.Visible = true;
            //this.Visible = false;
        }

        private void ModuloAdministativo_Click(object sender, EventArgs e)
        {
            if (btnListadoAsignaturas.Visible == true)
            {
                btnConsultaUsuarios.Visible = false;
                btnCalificaciones.Visible = false;
                btnListadoAsignaturas.Visible = false;
                btnListadoEstudiantes.Visible = false;
                btnAsignatura.Visible = true;
                btnEmpleado.Visible = true;
                btnEstudiante.Visible = true;
                btnTutor.Visible = true;
            }
            else if (btnConsultaUsuarios.Visible == true)
            {
                btnConsultaUsuarios.Visible = false;
                btnCalificaciones.Visible = false;
                btnListadoAsignaturas.Visible = false;
                btnListadoEstudiantes.Visible = false;
                btnAsignatura.Visible = true;
                btnEmpleado.Visible = true;
                btnEstudiante.Visible = true;
                btnTutor.Visible = true;
            }
            else
            {
                btnAsignatura.Visible = true;
                btnEmpleado.Visible = true;
                btnEstudiante.Visible = true;
                btnTutor.Visible = true;
            }
        }

        private void ModuloEducativo_Click(object sender, EventArgs e)
        {
            if (btnTutor.Visible == true)
            {
                btnTutor.Visible = false;
                btnEmpleado.Visible = false;
                btnEstudiante.Visible = false;
                btnAsignatura.Visible = false;
                btnCalificaciones.Visible = true;
                btnListadoAsignaturas.Visible = true;
                btnListadoEstudiantes.Visible = true;
                btnConsultaUsuarios.Visible = false;
            }
            else if (btnConsultaUsuarios.Visible == true)
            {

                btnTutor.Visible = false;
                btnEmpleado.Visible = false;
                btnEstudiante.Visible = false;
                btnAsignatura.Visible = false;
                btnCalificaciones.Visible = true;
                btnListadoAsignaturas.Visible = true;
                btnListadoEstudiantes.Visible = true;
                btnConsultaUsuarios.Visible = false;
            }
            else
            {
                btnCalificaciones.Visible = true;
                btnListadoAsignaturas.Visible = true;
                btnListadoEstudiantes.Visible = true;
            }
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

        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            ConsultaAsignaturaAdministrativa link = new ConsultaAsignaturaAdministrativa();
            //link.MdiParent = this;
            link.Visible = true;
            //this.Visible = false;
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            ConsultaEmpleadoAdministrativo link = new ConsultaEmpleadoAdministrativo();
            //link.MdiParent=this;
            link.Visible = true;
            //this.Visible = false;
        }

        private void btnListadoEstudiantes_Click_1(object sender, EventArgs e)
        {
            listadoEstudiantes link = new listadoEstudiantes();
            link.docente.Text = this.Nombre.Text;
            link.labelID.Text = this.labelID.Text;
            link.Show();

            
        }

        private void btnListadoAsignaturas_Click_1(object sender, EventArgs e)
        {
            listadoAsignaturas link = new listadoAsignaturas();
            link.docente.Text = this.Nombre.Text;
            link.labelID.Text = this.labelID.Text;
            link.Show();
            link.Show();
        }

        private void ModuloAdministracionUsuarios_Click(object sender, EventArgs e)
        {
            if (btnCalificaciones.Visible == true)
            {
                btnConsultaUsuarios.Visible = true;
                btnCalificaciones.Visible = false;
                btnListadoAsignaturas.Visible = false;
                btnListadoEstudiantes.Visible = false;
                btnAsignatura.Visible = false;
                btnEmpleado.Visible = false;
                btnEstudiante.Visible = false;
                btnTutor.Visible = false;
            }
            else if (btnTutor.Visible == true)
            {
                btnConsultaUsuarios.Visible = true;
                btnCalificaciones.Visible = false;
                btnListadoAsignaturas.Visible = false;
                btnListadoEstudiantes.Visible = false;
                btnAsignatura.Visible = false;
                btnEmpleado.Visible = false;
                btnEstudiante.Visible = false;
                btnTutor.Visible = false;
            }
            {
                btnConsultaUsuarios.Visible = true;
            }
        }

        private void btnConsultaUsuarios_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios link = new ConsultaUsuarios();
            link.Visible = true;
            link.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //ReporteCalificaciones m = new ReporteCalificaciones();
            //m.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //ReporteListaGrado m = new ReporteListaGrado();
            //m.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //ReporteGradoAsignatura m = new ReporteGradoAsignatura();
            //m.Show();
        }

        private void btnTutor_Click_1(object sender, EventArgs e)
        {
            ConsultaTutor ct = new ConsultaTutor();
            ct.ShowDialog();
        }

        private void btnEstudiante_Click_1(object sender, EventArgs e)
        {
            Mantenimineto m = new Mantenimineto();
            m.Show();
            
        }
    }
}
