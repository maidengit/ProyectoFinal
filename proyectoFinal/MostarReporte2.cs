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
    public partial class MostarReporte2 : Form
    {
        public MostarReporte2()
        {
            InitializeComponent();
        }

        public string grado { get; set; }


        private void MostarReporte2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spListaGrado' Puede moverla o quitarla según sea necesario.
            this.spListaGradoTableAdapter.Fill(this.DataSetPrincipal.spListaGrado,grado);

            this.reportViewer1.RefreshReport();
        }
    }
}
