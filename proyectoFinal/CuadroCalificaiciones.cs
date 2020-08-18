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
        public string ParT;
        public string AsT;
        public string NombreT;
        private void CuadroCalificaiciones_Load(object sender, EventArgs e)
        {
            con = new ConexionN();
            if (Editar)
            {
                string grado1 = cbGrado.Text;
                cbGrado.Enabled = false;
                if (grado1.Equals("SEPTIMO") || grado1.Equals("OCTAVO") || grado1.Equals("NOVENO"))
                {
                    cbParcial.Items.Add("I Parcial");
                    cbParcial.Items.Add("II Parcial");
                    cbParcial.Items.Add("III Parcial");
                    cbParcial.Items.Add("IV Parcial");
                }
                else
                {
                    cbParcial.Items.Add("I Parcial, I Semestre");
                    cbParcial.Items.Add("II Parcial, I Semestre");
                    cbParcial.Items.Add("I Parcial, II Semestre");
                    cbParcial.Items.Add("II Parcial, II Semestre");
                }
                cbEstudiante.Enabled = false;
                cbAsignatura.Enabled = false;
                cbParcial.Enabled = false;
                con.llenarComboBox(cbAsignatura, "asignatura where gradoID in(select gradoID from grado where curso='" + grado1 + "')", "nombre");            }
            else
            {
                cbGrado.Text = "---Seleccione un Item---";
                con.llenarComboBox(cbGrado, "grado", "Curso");
                cbAsignatura.Text = "Es necesario seleccionar un Grado";
                cbEstudiante.Text = "Es necesario seleccionar un Grado";
                cbParcial.Text = "Es necesario seleccionar un Grado";
            }
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
            cbEstudiante.Text = "---Seleccione un Item---";
            if (cbEstudiante.Items.Count > 0)
            {
                cbEstudiante.Items.Clear();
            }
            con.llenarComboBox(cbEstudiante, "Estudiante where gradoID in(select gradoID from grado where curso='" + grado1 + "')", "nombre");
            cbParcial.Text = "---Seleccione un Item---";
            if (cbParcial.Items.Count > 0)
            {
                cbParcial.Items.Clear();
            }
            cbParcial.Text = "---Seleccione un Item---";
            if (grado1.Equals("SEPTIMO") || grado1.Equals("OCTAVO") || grado1.Equals("NOVENO"))
            {
                cbParcial.Items.Add("I Parcial");
                cbParcial.Items.Add("II Parcial");
                cbParcial.Items.Add("III Parcial");
                cbParcial.Items.Add("IV Parcial");
            }
            else
            {
                cbParcial.Items.Add("I Parcial, I Semestre");
                cbParcial.Items.Add("II Parcial, I Semestre");
                cbParcial.Items.Add("I Parcial, II Semestre");
                cbParcial.Items.Add("II Parcial, II Semestre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                //editar();
                MessageBox.Show("Calificacion Editada correctamente");
            }
            else
            {
                MessageBox.Show("Calificacion agregada correctamente");
                // guardar();
            }          
        }
        private void guardar()
        {
            string Asignatura = cbAsignatura.SelectedItem.ToString();
            string alumno = cbEstudiante.SelectedItem.ToString();
            int Parcial = cbParcial.SelectedIndex+1;
            float calificacion = (float)nmCalificacion.Value;
            con.ingresar(alumno, Asignatura, calificacion, Parcial);
        }
        private void editar()
        {
            con.actualizarCalificacion((float)nmCalificacion.Value, ParT, AsT, NombreT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro de Cancelar", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                MantenimientoCalificaciones mc = new MantenimientoCalificaciones();
                mc.ShowDialog();
                this.Dispose();
            }
        }
    }
}
