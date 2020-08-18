using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaCon;

namespace proyectoFinal
{
    public partial class Mantenimineto : Form

    {
        
        Conexion c = new Conexion();
        public Mantenimineto()
        {
            InitializeComponent();
        }

        private void Mantenimineto_De_Estudiantes_Load(object sender, EventArgs e)
        {
            c.con.Close();
            tabla1.DataSource = c.Llenartabla(null, 0).Tables[0];
            c.Llenarcob(Gradobox, "curso", "Grado");
            c.Llenarcob(estudianteBox2, "Nombre", "Estudiante");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Gradobox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Gradobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (Gradobox.SelectedIndex > 0)
            {
                string[] valores = c.capturarID(Gradobox.Text);
                ID = int.Parse(valores[0]);
                c.Llenarcob2(estudianteBox2, ID, "Estudiante");
                tabla1.DataSource = c.Llenartabla(null, ID).Tables[0];
            }
            else

            {
                c.Llenarcob(estudianteBox2, "Nombre", "Estudiante");
                tabla1.DataSource = c.Llenartabla(null, 0).Tables[0];
            }
        }
        private void estudianteBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID;
            if (estudianteBox2.SelectedIndex > 0)
            {
                string[] valores = c.capturarID(Gradobox.Text);
                ID = int.Parse(valores[0]);
                tabla1.DataSource = c.Llenartabla(estudianteBox2.Text, ID).Tables[0];
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RegistroEstudiante r = new RegistroEstudiante();
            this.Close();
            r.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tabla1.Rows.Count==0)
            {
                MessageBox.Show("Tiene que elgir un estudiante:");
            }
            else
            {
               string nombre;
               nombre= this.tabla1.CurrentRow.Cells[0].Value.ToString();               
                string [] datos= c.capturarEstudiante(nombre);               
                string fecha= datos[7] ;              
                RegistroEstudiante rg = new RegistroEstudiante();               
                rg.nombretxt.Text = datos[1];
                rg.identidadtxt.Text = datos[5];
                rg.tiposangretxt.Text = datos[6];
                rg.tutorid = datos[4];
                if (datos[2] == "M")
                { rg.radioButton1.Select(); }
                else { rg.radioButton2.Select(); }
                rg.fecha.Text = datos[3];
                rg.tutortxt.Text=c.capturarTutorNombre(datos[4]);
                rg.bandera = true;
                rg.gradoID = datos[8];
                rg.EstudianteID= datos[0];
                rg.indi = " ";
                rg.Show();
                this.Hide();            
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.tabla1.Rows.Count == 0)
            {
                MessageBox.Show("Tiene que elgir un estudiante:");
            }
            else
            {
                string nombre;
                nombre = this.tabla1.CurrentRow.Cells[0].Value.ToString();
                string[] datos = c.capturarEstudiante(nombre);
                DialogResult dr = MessageBox.Show("Esta Seguro que desea Cancelar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                { 
                try
                {
                    c.EliminarEstudiante(datos[0]);
                    MessageBox.Show("Se a eleminado El estudiante");
                    tabla1.DataSource = c.Llenartabla(null, 0).Tables[0];
                    c.Llenarcob(Gradobox, "curso", "Grado");
                    c.Llenarcob(estudianteBox2, "Nombre", "Estudiante");
                }
                catch (Exception)
                {
                    throw;
                }
                }
            }
    }
        private void menupic_Click(object sender, EventArgs e)
        {
            //Menu link = new Menu();
            //link.Show();
            this.Dispose();
        }
        private void Restaurarpic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizarpic.Visible = true;
            Restaurarpic.Visible = false;
        }
        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mantenimineto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();               
            }
        }
    }
}


