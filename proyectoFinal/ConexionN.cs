using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public ConexionN()
        {
            try
            {
                //Conexion de Melvin
                con = new SqlConnection("Data Source=DESKTOP-AO482B2\\SQLEXPRESS;Initial Catalog=proyescuela2;Integrated Security=True");
                //Conexion de Nata
                //con = new SqlConnection("Data Source=DESKTOP-KV58B2F\\SQLEXPRESS;Initial Catalog=proyescuela;Integrated Security=True");
                //Conexion de ...
                //con = new SqlConnection("Data Source = DESKTOP - 76J3QBF\\SQLEXPRESS; Initial Catalog = proyescuela; Integrated Security = True");
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                Console.WriteLine(e.Message);
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
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void llenarComboBox(ComboBox comboBox, string tabla, string campo)
        {
            try
            {
                string sql = "select * from " + tabla;
                cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr[campo].ToString());
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private int BuscarID(Boolean EsAsignatura, string valor)
        {
            int informacion = 0;
            try
            {
                if (EsAsignatura == false)
                {
                    string sql = "select EstudianteID from Estudiante where nombre='" + valor + "'";
                    cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        informacion = (int)dr[0];
                    }
                    dr.Close();
                    return informacion;
                }
                else
                {
                    string sql = "select AsignaturaID from asignatura where nombre='" + valor + "'";
                    cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        informacion = (int)dr[0];
                    }
                    dr.Close();
                    return informacion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public void ingresar(string NEstudiante, string NAsignatura, float nota, int parcial)
        {
            try
            {
                int EsId = BuscarID(false, NEstudiante);
                int AsId = BuscarID(true, NAsignatura);
                string sql = string.Format("EXEC spAgregarCalificacion {0},{1},{2},{3}", AsId, nota,parcial,EsId);
                cmd = new SqlCommand(sql, con);
                MessageBox.Show(sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Calificacion Ingresada"); 
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al ingresar una calificacion ");
                Console.WriteLine(e.Message);
            }
        }
        
        public void actualizarCalificacion(float calificacion, string parcial, string asignatura, string nombre)
        {
            try
            {
                int CalificacionId = CaID(parcial, asignatura, nombre);
                string sql1 = "update calificaciones set notaparcial=" + calificacion +" where calificacionID=" + CalificacionId;
                cmd = new SqlCommand(sql1, con);
                MessageBox.Show(sql1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Calificacion Actualizada");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al ingresar una calificacion ");
                Console.WriteLine(e.Message);
            }
        }
        private int CaID(string parcial, string asignatura, string nombre)
        {
            try
            {
                int CalificacionId = 0;
                string sql = "select calificacionID,asignaturaID,numeroparcial from vCalificaciones where parcial = '" + parcial + "' and " +
                    "materia='" + asignatura + "' and nombre='" + nombre + "'";
                cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CalificacionId = (int)dr["calificacionID"];
                }
                dr.Close();
                return CalificacionId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public void Eliminar(string parcial, string asignatura, string nombre)
        {
            try
            {
                int CalificacionId = CaID(parcial, asignatura, nombre);
                string sql1 = "delete from calificaciones where calificacionID=" + CalificacionId;
                cmd = new SqlCommand(sql1, con);
                MessageBox.Show(sql1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Calificacion Eliminada");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
