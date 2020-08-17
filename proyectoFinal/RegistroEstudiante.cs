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

    public partial class RegistroEstudiante : Form
    {
        public string bamderat = "1" ;
        public string EstudianteID;
        public string tutorid;
        public string indi;
        public Boolean bandera=false;
        

        public string gradoID;
        Conexion c = new Conexion();
        public RegistroEstudiante()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimineto m = new Mantenimineto();
           DialogResult dr= MessageBox.Show("Esta Seguro que desea Cancelar", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr==DialogResult.Yes)
            {
                this.Close();
                m.Show();

            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void RegistroEstudiante_Load(object sender, EventArgs e)
        {                                 
            if (gradoID == null)
            {
                c.Llenarcob(gradoBox, "GradoID", "Grado");
            }
            else
            {
                string curso1;
              curso1 = c.capturarGrado(gradoID);
               gradoBox.Text = curso1;
                c.LlenarcobEditar(gradoBox, "GradoID", "Grado");
            }                   
        }
        private void tutortxt_MouseClick(object sender, MouseEventArgs e)
        {
            bamderat = "2";
            RegistroTutor tutorf = new RegistroTutor();
            tutorf.ban.Text = bamderat;
            tutorf.ShowDialog();
            if (tutorf.DialogResult== DialogResult.OK)
            { 
            tutortxt.Text = tutorf.Nombretutorbox.Text;
            tutorid = tutorf.ID.ToString();

            }
        }
        private void tutortxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public static Boolean ValidarDatos(Control objeto, ErrorProvider errorProvider)
        {
            Boolean errores = false;

            foreach (Control Item in objeto.Controls)
            {
                if (Item is ErrorTxt)
                {
                    ErrorTxt obj = (ErrorTxt)Item;
                    if (obj.validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "No puede estar vacio");
                            errores = true;
                        }
                    }
                    else
                    {
                        errorProvider.SetError(obj, "");
                     }

                    if(obj.soloNumeros==true)
                    {
                        int con=0,letras=0;
                        foreach(char letra in obj.Text.Trim())
                        {
                            if(char.IsLetter(obj.Text.Trim(),con))
                            {
                                letras++;
                            }
                            con++;
                        }
                        if(letras!=0)
                        {
                             errores = true;
                            errorProvider.SetError(obj, "Este campo solo acepta Numeros");
                        }
                    }
                }
            }
            return errores;
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
           Guar();
            
        }
        public void Guar()
        {
            if (ValidarDatos(this, errorProvider1) == false )
            {
                string fecha2 ;
               if (bandera == false)
                {
                EstudianteID = c.capturaresttudianteID();
                }
                fecha2 = c.FormatoFecha(fecha);
                if (gradoBox.SelectedIndex > 0 | bandera==true )
            {
                string[] valores = c.capturarID(gradoBox.Text);
                gradoID = valores[0];
                    string sexo="";
            if (radioButton1.Checked)
            { sexo = "M"; }
            if (radioButton2.Checked)
            { sexo = "F"; }            
                try
                {
                    string cmd = string.Format("  exec spInsertarActuarlizar {0},'{1}','{2}','{3}',{4},'{5}','{6}',{7},'A'" +
                    "", EstudianteID, nombretxt.Text.Trim(), sexo, fecha2, tutorid, identidadtxt.Text.Trim(), tiposangretxt.Text.Trim(), gradoID);
                    c.Ejecutar(cmd);
                        if (bandera == false) 
                        { 
                         MessageBox.Show("Se a guardado Exitosamente");
                        }
                        else
                        {
                         MessageBox.Show("Se a Actualizado Exitosamente");
                            Mantenimineto m = new Mantenimineto();
                            m.Show();
                            this.Close();
                        }
                        nombretxt.Text = "";
                        identidadtxt.Text = "";
                        tutortxt.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        tiposangretxt.Text = "";
                       c.Llenarcob(gradoBox, "GradoID", "Grado");
                    }
                    catch (Exception ex)
                {
                    MessageBox.Show("A ocurrido un error:" + ex.Message);
                    throw;
                }
                }
                else
                {
                    MessageBox.Show("Tiene que elegir un Grado:", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {               
                return  ;
            }
        }
        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {           
        }
        private void RegistroEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Mantenimineto m = new Mantenimineto();
                DialogResult dr = MessageBox.Show("Esta Seguro que desea Cancelar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                    m.Show();
                }
            }
           
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void identidadtxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
