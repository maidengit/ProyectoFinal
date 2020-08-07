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
            CuadroCalificaiciones CC = new CuadroCalificaiciones();
            CC.MdiParent = this;
            CC.Show();
        }
    }
}
