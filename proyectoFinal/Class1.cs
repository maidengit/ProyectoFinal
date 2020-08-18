using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Drawing;
using System.Windows.Forms.PropertyGridInternal;

namespace LibreriaCon
{
    public class Conexion
    {
      public SqlConnection con;
        public Conexion()
        {
           try
            {
                //con = new SqlConnection("Data Source=DESKTOP-AO482B2\\SQLEXPRESS;Initial Catalog=proyescuela2;Integrated Security=True");
                  con = new SqlConnection("Data Source = DESKTOP-76J3QBF\\SQLEXPRESS; Initial Catalog = proyescuela; Integrated Security = True");
            }
            catch (Exception )
            {

            }
        }
        public DataSet Ejecutar(String cmd)
        {
            con.Open();
            DataSet d = new DataSet();
             SqlDataAdapter ds = new SqlDataAdapter(cmd, con);
             ds.Fill(d);
            con.Close();
            return d;
            
        }
        public DataSet Llenartabla(String nombre, int grado)
        {
            
            DataSet ds;
            String cmd = string.Format("exec spconsultaestudiantes '{0}',{1}", nombre, grado);
            ds = Ejecutar(cmd);
            con.Close();

            return ds;
            
        }
        public DataSet Llenartabla2(String nombre)
        {

            DataSet ds;
            String cmd = string.Format("exec spconsultatutor '{0}'", nombre);
            ds = Ejecutar(cmd);
            con.Close();

            return ds;

        }

        public void Llenarcob (ComboBox cb,String Campo,String tabla)
        {
            cb.Items.Clear();
            con.Open();
            string cmd1 = String.Format("select * from {0} ", tabla,Campo);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader c = cmd.ExecuteReader();
            while (c.Read())
            {

                cb.Items.Add(c[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0, "--- Seleccione Un " + tabla + "----");
            cb.SelectedIndex = 0;

        }

        public void Llenarcob2(ComboBox cb, int Campo, String tabla)
        {

            cb.Items.Clear();

            con.Open();
            string cmd1 = String.Format("select * from {0} where GradoID= {1}", tabla, Campo);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader c = cmd.ExecuteReader();
            while (c.Read())
            {

                cb.Items.Add(c[1].ToString());
            }
            con.Close();

           

        }


        public string[] capturarID(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from Grado where curso= '{0}'",nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 = { dr[0].ToString()};

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }
        public string capturarTutorID(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from Tutor where Nombre= '{0}'", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 =  dr[0].ToString() ;

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }

        public string capturaresttudianteID()
        {
            con.Open();
            string cmd1 = string.Format("Select dbo.EstudianteID(1) ");
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 =  dr[0].ToString() ;

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }

        public string capturartutor1ID()
        {
            con.Open();
            string cmd1 = string.Format("Select dbo.tutorID(1)");
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 = dr[0].ToString();

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }
        public  string FormatoFecha(DateTimePicker LaFecha)
        {
            string s, dia, mes, year, d1="";
            year = LaFecha.Value.Year.ToString();
            mes = LaFecha.Value.Month.ToString();
            dia = LaFecha.Value.Day.ToString();
            long  dia1= Int32.Parse(dia);

            s = year;
           
            if (Int64.Parse(mes) < 10)
            {
                d1 = "0" + mes;           
            }
            else
            {
                d1 +=  mes  ;
            }
            s += d1;

            if (  dia1< 10)
            {
                d1 = "0" + dia;
            }
            else
            {
                d1 = dia;
            }
            s += d1;
            return s;
        }

        public string[] capturarEstudiante(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from Estudiante where Nombre='{0}'", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 = 
                 {
                   
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),
                    dr[8].ToString()

                };

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }

        public string capturarTutorNombre(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from Tutor where tutorID= {0}", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 =  dr[1].ToString() ;

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }

        public string capturarGrado(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from grado where gradoID= {0}", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 = dr[1].ToString();

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }


        public void LlenarcobEditar(ComboBox cb, String Campo, String tabla)
        {
            cb.Items.Clear();
            con.Open();
            string cmd1 = String.Format("select * from {0} ", tabla, Campo);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader c = cmd.ExecuteReader();
            while (c.Read())
            {

                cb.Items.Add(c[1].ToString());
            }
            con.Close();
            

        }

        public void EliminarEstudiante( String id)
        {
            
            con.Open();
            string cmd1 = String.Format("  exec speleminarestudiante {0}",id );
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader c = cmd.ExecuteReader();
            
            con.Close();


        }

        public string[] capturarInfTutor(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from tutor where tutorID={0}", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 =
                 {

                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),
                    dr[8].ToString(),dr[9].ToString(),dr[10].ToString()

                };

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }
        public string[] capturarInfTutor2(String nombre)
        {
            con.Open();
            string cmd1 = string.Format("Select * from tutor where Nombre='{0}'", nombre);
            SqlCommand cmd = new SqlCommand(cmd1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores1 =
                 {

                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),
                    dr[8].ToString(),dr[9].ToString(),dr[10].ToString()

                };

                resultado = valores1;
            }
            con.Close();
            return resultado;

        }




    }
}

