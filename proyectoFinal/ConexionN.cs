using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    class ConexionN
    {
        public SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ConexionN()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-KV58B2F\\SQLEXPRESS;Initial Catalog=proyescuela;Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Grado(DataGridView tabla, string grado, string materia, string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spCalificacionesPorGrado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Grado", SqlDbType.VarChar, 30).Value = grado;
                cmd.Parameters.Add("@Materia", SqlDbType.VarChar, 30).Value = materia;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 15).Value = nombre;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Opcional(DataGridView tabla, string sexo, string estado, string grado, string materia, string nombre, string tipo)
        {
            try
            {
                string sql = "select Nombre,Grado,Parcial,Materia,Calificacion from vCalificaciones ";
                if ((sexo.Equals("nada") == false) || (grado.Equals("nada") == false) || (estado.Equals("nada") == false) || (materia.Equals("nada") == false) || (nombre.Equals("nada") == false) || (tipo.Equals("nada") == false))
                {
                    sql += "where ";
                    if (sexo.Equals("nada") == false)
                    {
                        sql += " sexo = '" + sexo + "' ";
                        sql += "and";
                    }
                    if (estado.Equals("nada") == false)
                    {
                        sql += " estado = '" + estado + "' ";
                        sql += "and";
                    }
                    if (materia.Equals("nada") == false)
                    {
                        sql += " materia = '" + materia + "' ";
                        sql += "and";
                    }
                    if (nombre.Equals("nada") == false)
                    {
                        sql += " nombre like '%" + nombre + "%' ";
                        sql += "and";
                    }
                    if (grado.Equals("nada") == false)
                    {
                        sql += " grado = '" + grado + "' ";
                        sql += "and";
                    }
                    if (tipo.Equals("nada") == false)
                    {
                        sql += " tipo = '" + tipo + "' ";
                        sql += "and";
                    }
                    sql = sql.Remove(sql.Length - 3);
                }
                MessageBox.Show(sql);
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void llenarComboBox(ComboBox comboBox, string tabla, string campo)
        {
            try
            {
                string sql = "select * from " + tabla;
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr[campo].ToString());
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo paso" + e.ToString());
            }
        }
    }
}
