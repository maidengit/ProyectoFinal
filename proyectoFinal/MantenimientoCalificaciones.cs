using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        ConexionN Conectar;
        int ControlA = 0;int ControlR = 0;
        int ControlM = 0;int ControlF = 0;
        int ControlAvz = 0;int ControlMB = 0;int ControlB = 0;int ControlI = 0;
        string sexo = "";string grado = "";string materia = "";string nombre = "";string estado = "";string tipo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            CuadroCalificaiciones CC = new CuadroCalificaiciones();
            CC.MdiParent = this.MdiParent;
            CC.Editar = false;
            CC.Show();
            this.Hide();
        }
        private void rbAprovado_MouseClick(object sender, MouseEventArgs e)
        {
            ControlA++;
            ControlR=0;
            if (ControlA % 2 == 0) { rbAprobado.Checked = false; }
        }

        private void rbReprovado_MouseClick(object sender, MouseEventArgs e)
        {
            ControlR++;
            ControlA=0;
            if (ControlR%2 == 0)
            {
                rbReprobado.Checked = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            CuadroCalificaiciones CC = new CuadroCalificaiciones();
            CC.MdiParent = this.MdiParent;
            CC.Editar = true;
            CC.Show();
            this.Hide();
        }

        private void rbAvanzado_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAvz++;
            ControlMB = 0; ControlB = 0; ControlI = 0;
            if (ControlAvz % 2 == 0)
            {
                rbAvanzado.Checked = false;
            }
        }

        private void rbInsuficiente_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAvz = 0;
            ControlMB = 0; ControlB = 0; ControlI++;
            if (ControlI % 2 == 0)
            {
                rbInsuficiente.Checked = false;
            }
        }

        private void rbMuySatisfactorio_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAvz = 0;
            ControlMB++; ControlB = 0; ControlI = 0;
            if (ControlMB % 2 == 0)
            {
                rbMuySatisfactorio.Checked = false;
            }
        }

        private void rbSatisfactorio_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAvz = 0;
            ControlMB = 0; ControlB++; ControlI = 0;
            if (ControlB % 2 == 0)
            {
                rbSatisfactorio.Checked = false;
            }
        }

        private void MantenimientoCalificaciones_Load(object sender, EventArgs e)
        {
            Conectar = new ConexionN();
            try
            {
                MessageBox.Show("Todo bien");
                llenar();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            cbGrado.Text = "---Seleccione un Item---";
            cbAignatura.Text = "---Es necesario seleccionar un grado---";
            Conectar.llenarComboBox(cbGrado, "grado", "curso");
        }
        private void llenar()
        {
            Conectar = new ConexionN();
            if(rbAprobado.Checked || rbReprobado.Checked)
            {
                if (rbAprobado.Checked) { estado = "Aprobado"; }
                if (rbReprobado.Checked) { estado = "Reprobado"; }
            }
            else { estado = "nada"; }

            if(rbMasculino.Checked || rbFemenino.Checked)
            {
                if (rbMasculino.Checked) { sexo = "M"; }
                if (rbFemenino.Checked) { sexo = "F"; }
            }
            else { sexo = "nada"; }
            if(rbAvanzado.Checked || rbMuySatisfactorio.Checked || rbSatisfactorio.Checked || rbInsuficiente.Checked)
            {
                if (rbInsuficiente.Checked) { tipo = "insuficiente"; }
                if (rbAvanzado.Checked) { tipo = "avanzado"; }
                if (rbMuySatisfactorio.Checked) { tipo = "muy satisfactorio"; }
                if (rbSatisfactorio.Checked) { tipo = "satisfactorio"; }
            }
            else { tipo = "nada"; }
            if (cbGrado.SelectedIndex.ToString().Equals("-1")) { grado = "nada"; }
            else { grado = cbGrado.SelectedItem.ToString(); }
            if (cbAignatura.SelectedIndex.ToString().Equals("-1")) { materia = "nada"; }
            else { materia = cbAignatura.SelectedItem.ToString(); }
            if (txtNombre.TextLength == 0) { nombre = "nada"; }
            Conectar.Opcional(Tabla,sexo,estado,grado,materia,nombre,tipo);
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conectar = new ConexionN();
            string grado1 = cbGrado.SelectedItem.ToString();
            llenar();
            if (cbAignatura.Items.Count > 0)
            {
                cbAignatura.Items.Clear();
                cbAignatura.Text = "---Seleccione un Item---";
                Conectar.llenarComboBox(cbAignatura, "asignatura where gradoID in(select gradoID from grado where curso='" + grado1 + "')", "nombre");
            }
            else
            {
                cbAignatura.Text = "---Seleccione un Item---";
                Conectar.llenarComboBox(cbAignatura, "asignatura where gradoID in(select gradoID from grado where curso='"+grado1+"')", "nombre");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void cbAignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            grado = cbAignatura.SelectedItem.ToString();
            llenar();
        }

        private void rbAprobado_CheckedChanged(object sender, EventArgs e)
        {
            llenar();            
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            llenar();
        }

        private void rbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }

        private void rbMuySatisfactorio_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }

        private void rbSatisfactorio_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }

        private void rbInsuficiente_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }

        private void rbReprobado_CheckedChanged(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
