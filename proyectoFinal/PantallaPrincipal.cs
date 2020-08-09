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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void calificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MantenimientoCalificaciones mc = new MantenimientoCalificaciones();
            mc.MdiParent = this;
            mc.Show();
        }

        private void listadoDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadoEstudiantes li = new listadoEstudiantes();
            li.MdiParent = this;
            li.Show();
        }

        private void consultaDeAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaDeAsignaturas ca = new consultaDeAsignaturas();
            ca.MdiParent = this;
            ca.Show();
        }
    }
}
