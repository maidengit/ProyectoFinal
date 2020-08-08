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
    public partial class MantenimientoCalificaciones : Form
    {
        public MantenimientoCalificaciones()
        {
            InitializeComponent();
        }
        int ControlA = 0;
        int ControlR = 0;
        int ControlM = 0;
        int ControlF = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            CuadroCalificaiciones CC = new CuadroCalificaiciones();
            CC.MdiParent = this.MdiParent;
            CC.Show();
            this.Hide();
        }

        private void rbAprovado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbAprovado_MouseClick(object sender, MouseEventArgs e)
        {
            ControlA++;
            ControlR=0;
            if (ControlA%2==0)
            {
                rbAprovado.Checked = false;
            }
        }

        private void rbReprovado_MouseClick(object sender, MouseEventArgs e)
        {
            ControlR++;
            ControlA=0;
            if (ControlR%2 == 0)
            {
                rbReprovado.Checked = false;
            }
        }

        private void rbMasculino_MouseClick(object sender, MouseEventArgs e)
        {
            ControlF = 0;
            ControlM++;
            if (ControlM % 2 == 0)
            {
                rbMasculino.Checked = false;
            }
        }

        private void rbFemenino_MouseClick(object sender, MouseEventArgs e)
        {
            ControlF++;
            ControlM = 0; ;
            if (ControlF % 2 == 0)
            {
                rbFemenino.Checked = false;
            }
        }
    }
}
