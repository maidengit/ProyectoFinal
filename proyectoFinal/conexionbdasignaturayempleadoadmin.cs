using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Configuration;

namespace proyectoFinal
{
    class conexionbdasignaturayempleadoadmin
    {
        //string cadena = "Data Source=DESKTOP-70OJMFT\\MIKTO;Initial Catalog=proyescuela;Integrated Security=True";
        //string cadena = "Data Source=DESKTOP-76J3QBF\\SQLEXPRESS;Initial Catalog=proyescuela;Integrated Security=True";
        //string cadena = " Data Source = DESKTOP - AO482B2\\SQLEXPRESS;Initial Catalog = proyescuela2; Integrated Security = True";
        string cadena = "Data Source=DESKTOP-KV58B2F\\SQLEXPRESS;Initial Catalog=proyescuela1;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        DataSet ds;

        public conexionbdasignaturayempleadoadmin()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Abierta");
            }catch (Exception ex)
            {
                Console.WriteLine("Error al abrir BD"+ ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }

        public DataTable mostrarDatos()
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand("select a.AsignaturaID,a.Nombre as AsignaturaNombre,e.nombre as Docente, g.Curso," +
                "a.Semestre from Asignatura a inner join empleado e on a.EmpleadoID=e.EmpleadoID inner join grado g on g.GradoID = a.GradoID", conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds,"tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarGrado(String curso)
        {
            
            SqlCommand cmd = new SqlCommand(String.Format("select a.AsignaturaID,a.Nombre as AsignaturaNombre,e.nombre as Docente, g.Curso, " +
                "a.Semestre from Asignatura a inner join empleado e on a.EmpleadoID=e.EmpleadoID inner join grado g on g.GradoID = a.GradoID " +
                " where g.Curso like '%{0}%'",curso), conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarDocente(String docente)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("select a.AsignaturaID,a.Nombre as AsignaturaNombre,m.nombre as Docente, " +
                "g.Curso,a.Semestre from Asignatura a inner join empleado m on a.EmpleadoID= m.EmpleadoID inner join " +
                "grado g on g.GradoID = a.GradoID where m.Nombre like '%{0}%'", docente), conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarAsignatura(String docente)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("select a.AsignaturaID,a.Nombre as AsignaturaNombre,m.nombre as Docente, " +
                "g.Curso,a.Semestre from Asignatura a inner join empleado m on a.EmpleadoID= m.EmpleadoID inner join " +
                "grado g on g.GradoID = a.GradoID where a.nombre like '%{0}%'", docente), conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public bool InsertarAsignatura(String id, String nombre, String EmpleadoID, String GradoID, String Semestre)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Insert into Asignatura values({0}, '{1}', {2}, {3}, {4})",
                new String[] {id, nombre,EmpleadoID,GradoID,Semestre }), conectarbd);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool EliminarAsignatura(String id)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Delete from Asignatura where AsignaturaID ={0}",id ), conectarbd);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
            { conectarbd.Close(); return true; }
            else { conectarbd.Close(); return false; }
            
        }

        public bool UpdateAsignatura(String id, String nombre, String EmpleadoID, String GradoID, String Semestre)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("update Asignatura set Nombre = '{1}', EmpleadoID= {2}, GradoID = {3}, " +
                "Semestre = {4} where AsignaturaID = {0}", new String[] { id, nombre, EmpleadoID, GradoID, Semestre })
                , conectarbd);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public string asignaturaID()
        {
            conectarbd.Open();
            string cmd1 = "select MAX(a.AsignaturaID)+1 from Asignatura a";
            SqlCommand cmd = new SqlCommand(cmd1, conectarbd);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 = dr[0].ToString();

                resultado = valores1;
            }
            conectarbd.Close();
            return resultado;

        }

        public DataTable llenadoGrado ()
        {
            SqlDataAdapter da = new SqlDataAdapter("select grado.Curso from grado", conectarbd);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable llenadoDocente()
        {
            SqlDataAdapter da = new SqlDataAdapter("select e.Nombre from empleado e inner join Departamento d on d.DepartamentoID=e.DepartamentoID " +
                "where e.DepartamentoID=1", conectarbd);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable mostrarDatosEmpleados()
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand("select e.EmpleadoID,e.Nombre,e.Identidad,e.FechaNacimiento, " +
                " d.Nombre Departamento,e.Telefono, e.Email from empleado e " +
                " inner join Departamento d on d.DepartamentoID = e.DepartamentoID ", conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable llenadoDepartamento()
        {
            SqlDataAdapter da = new SqlDataAdapter("select d.nombre from departamento d", conectarbd);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable llenadoEstadoCivil()
        {
            SqlDataAdapter da = new SqlDataAdapter("select d.nombre from departament d", conectarbd);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Insertarempleado(String id, String nombre, String identidad, String FechaNacimiento, String DepartamentoID,
            String dirrecion, String telefono, String email, String sexo, String EstadoCivil)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("Insert into Empleado values({0}, '{1}', '{2}', '{3}', {4}," +
                "'{5}', '{6}', '{7}', '{8}', '{9}')",
                new String[] { id, nombre, identidad, FechaNacimiento, DepartamentoID, dirrecion,telefono,email,sexo,EstadoCivil}), conectarbd);
            int filasafectadas = cmd.ExecuteNonQuery();
            conectarbd.Close();
        }
        public string empleadoID()
        {
            conectarbd.Open();
            string cmd1 = "select MAX(a.empleadoID)+1 from empleado a";
            SqlCommand cmd = new SqlCommand(cmd1, conectarbd);
            SqlDataReader dr = cmd.ExecuteReader();
            string resultado = null;
            while (dr.Read())
            {
                string valores1 = dr[0].ToString();

                resultado = valores1;
            }
            conectarbd.Close();
            return resultado;

        }

        public DataTable BuscarEmpleado(String nombre)
        {

            SqlCommand cmd = new SqlCommand(String.Format("select e.EmpleadoID,e.Nombre,e.Identidad, e.FechaNacimiento, " +
                " d.Nombre Departamento,e.Telefono, e.Email from empleado e inner join Departamento d on d.DepartamentoID = " +
                " e.DepartamentoID where e.Nombre like '%{0}%'", nombre), conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarEmpleadoporDepartamento(String nombre)
        {

            SqlCommand cmd = new SqlCommand(String.Format("select e.EmpleadoID,e.Nombre,e.Identidad, e.FechaNacimiento, " +
                " d.Nombre Departamento,e.Telefono, e.Email from empleado e inner join Departamento d on d.DepartamentoID = " +
                " e.DepartamentoID where d.Nombre like '%{0}%'", nombre), conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable mostrarDatos3()
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand("select e.EmpleadoID,e.Nombre,e.Identidad,e.FechaNacimiento,d.Nombre Departamento, "+
                    " e.Telefono, e.Email from empleado e inner " +
                    " join Departamento d on d.DepartamentoID = e.DepartamentoID", conectarbd);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conectarbd.Close();
            return ds.Tables["tabla"];
        }

        public DataTable llenadoCbDocente()
        {
            SqlDataAdapter da = new SqlDataAdapter("select d.nombre from departament d", conectarbd);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool UpdateEmpleado(String id, String nombre, String identidad, String fechanacimiento, String depid,
                        String Direccion, String telefono, String email, String sexo, String estado)
        {
            conectarbd.Open();
            SqlCommand cmd = new SqlCommand(String.Format("update Empleado set Nombre = '{1}', Identidad= '{2}', FechaNacimiento = '{3}', " +
                " DepartamentoID= {4} , Direccion= '{5}', Telefono='{6}', email='{7}',sexo='{8}',estadocivil='{9}' " +
                " where EmpleadoID = {0}", new String[] { id, nombre, identidad, fechanacimiento, depid, Direccion, 
                 telefono, email, sexo, estado })
                , conectarbd);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0) return true;
            else return false;
        }


    }
    }

