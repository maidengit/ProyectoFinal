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
    public partial class MostarReporte3 : Form
    {
        public MostarReporte3()
        {
            InitializeComponent();
        }

        public string grado { get; set; }
        public string asignatura { get; set; }

        public int semestre { get; set; }

        private void MostarReporte3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spGradoAsignatura' Puede moverla o quitarla según sea necesario.
            this.spGradoAsignaturaTableAdapter.Fill(this.DataSetPrincipal.spGradoAsignatura,grado,asignatura,semestre);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
