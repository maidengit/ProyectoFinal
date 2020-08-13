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
    public partial class CuadroCalificaiciones : Form
    {
        public CuadroCalificaiciones()
        {
            InitializeComponent();
        }
        public bool Editar;
        ConexionN con;
        private void CuadroCalificaiciones_Load(object sender, EventArgs e)
        {
            con = new ConexionN();
            if (Editar)
            {
                cbAsignatura.Enabled = false;
                cbEstudiante.Enabled = false;
                cbGrado.Enabled = false;
                cbParcial.Enabled = false;
            }
            cbGrado.Text = "---Seleccione un Item---";
            con.llenarComboBox(cbGrado,"grado","Curso");
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grado1 = cbGrado.SelectedItem.ToString();
            if (cbAsignatura.Items.Count > 0)
            {
                cbAsignatura.Items.Clear();
            }
            cbAsignatura.Text = "---Seleccione un Item---";
            con.llenarComboBox(cbAsignatura, "asignatura where gradoID in(select gradoID from grado where curso='" + grado1 + "')", "nombre");
        }

    }
}
