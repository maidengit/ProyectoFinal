using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCon;

namespace proyectoFinal
{
     
    public partial class ConsultaTutor : Form
    {
        Conexion c = new Conexion();
        public ConsultaTutor()
        {
            InitializeComponent();
        }

        private void ConsultaTutor_Load(object sender, EventArgs e)
        {

            tabla1.DataSource = c.Llenartabla2(null).Tables[0];
            
            c.Llenarcob(tutorBox2, "Nombre", "Tutor");
        }

        private void tutorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

         
            if (tutorBox2.SelectedIndex > 0)
            {
                tabla1.DataSource = c.Llenartabla2(tutorBox2.Text).Tables[0];
            }
            else
            {
                tabla1.DataSource = c.Llenartabla2(null).Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RegistroTutor rg = new RegistroTutor();
            rg.Show();
            this.Close();
        }
        private void menupic_Click(object sender, EventArgs e)
        {
            Menu link = new Menu();
            link.Show();
            this.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tabla1.Rows.Count == 0)
            {
                MessageBox.Show("Tiene que elgir un Tutor:");
            }
            else
            {
                string nombre;
                nombre = this.tabla1.CurrentRow.Cells[0].Value.ToString();
                RegistroTutor rg = new RegistroTutor();
                string[] d1 = c.capturarInfTutor2(nombre);
                rg.id1.Text = d1[0];
                rg.ban.Text = "3";
                rg.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Menu link = new Menu();
            link.Show();
            this.Close();
        }

        private void Cerrarpic_Click(object sender, EventArgs e)
        {
            Menu link = new Menu();
            link.Show();
            this.Close();
        }
    }
}
