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
    public partial class RegistroTutor : Form

    {
        public string ID;
        public string TutorID;
        Conexion c = new Conexion();   
        public RegistroTutor()
        {
            InitializeComponent();
        }
        private void errorTxt6_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
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
                    if (obj.soloNumeros == true)
                    {
                        int con = 0, letras = 0;
                        foreach (char letra in obj.Text.Trim())
                        {
                            if (char.IsLetter(obj.Text.Trim(), con))
                            {
                                letras++;
                            }
                            con++;
                        }
                        if (letras != 0)
                        {
                            errores = true;
                            errorProvider.SetError(obj, "Este campo solo acepta Numeros");

                        }
                    }
                }
            }
            return errores;
        }
        private void RegistroTutor_Load(object sender, EventArgs e)
        {
            RegistroEstudiante rg = new RegistroEstudiante();
            
            if (ban.Text == "2") {
                c.Llenarcob(Nombretutorbox, "Nombre", "Tutor");
            }

            if (ban.Text == "3") {
               
                ID =id1.Text;

           
            string[] valores = c.capturarInfTutor(ID);
                Nombretutorbox.Text= valores[1];
                parentescotxt.Text = valores[2];
            if (valores[3] == "M")
            { radioButton1.Select(); }
            else { radioButton2.Select(); }
            telefonotxt.Text = valores[4];
            celulartxt.Text = valores[5];
            celular2txt.Text = valores[6];
            emailtxt.Text = valores[7];
            identidadtxt.Text = valores[8];
            direcciontxt.Text = valores[9];
            nacionalidadtxt.Text = valores[10];
            }

            id1.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(this, errorProvider1) == false)
            {
                guardar();
            } else
            {
                return;
            }

            if (ID == null)
            {
                return;
            } else
            {
                DialogResult = DialogResult.OK;
                Close();

            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void Nombretutorbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nombretutorbox.SelectedIndex > 0)
            {              
                   ID = c.capturarTutorID(Nombretutorbox.Text);
                string[] valores = c.capturarInfTutor(ID);             
                parentescotxt.Text = valores[2];               
                if (valores[3] == "M")
                { radioButton1.Select(); }
                else {radioButton2.Select(); }
                telefonotxt.Text = valores[4];
                celulartxt.Text = valores[5];
                celular2txt.Text = valores[6];
                emailtxt.Text = valores[7];
                identidadtxt.Text = valores[8];
                direcciontxt.Text = valores[9];
                nacionalidadtxt.Text = valores[10];
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaTutor m = new ConsultaTutor();
            DialogResult dr = MessageBox.Show("Esta Seguro que desea Cancelar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                m.Show();
            }
        }
        public void guardar()
        {
            if (ban.Text == "2" | ban.Text == "3")
            {
                TutorID = ID;
            }else
            {
             TutorID = c.capturartutor1ID();
            }

             

            string sexo="";
            if (radioButton1.Checked)
            { sexo = "M"; }
            if (radioButton2.Checked)
            { sexo = "F"; }        
            try
            {

                string cmd = string.Format("  exec spInsertarActuarlizarTutor {0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}'",TutorID,Nombretutorbox.Text,
                    parentescotxt.Text,sexo,telefonotxt.Text,celulartxt.Text,celular2txt.Text,emailtxt.Text,identidadtxt.Text
                    ,direcciontxt.Text,nacionalidadtxt.Text);
                c.Ejecutar(cmd);                
                if (ban.Text == "2" | ban.Text == "3")
                {
                    MessageBox.Show("Se actualizo Exitosamente");
                    
                    if(ban.Text == "3")
                    {
                        ConsultaTutor ct = new ConsultaTutor();
                        ct.Show();
                    }
                        this.Close();
                }

                else 
                {
                    MessageBox.Show("Se a guardado Exitosamente");
                    this.Close();
                   ConsultaTutor ct = new ConsultaTutor();
                   ct.Show();
                }
              
                



            }
            catch (Exception ed)
            {
                MessageBox.Show("Error:" + ed.Message);

                throw;
            }
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void identidadtxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void nacionalidadtxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void telefonotxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void direcciontxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
