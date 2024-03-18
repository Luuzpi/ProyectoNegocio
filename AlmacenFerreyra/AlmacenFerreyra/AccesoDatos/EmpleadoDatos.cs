using AlmacenFerreyra.Presentacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AlmacenFerreyra.AccesoDatos
{
    public class EmpleadoDatos
    {
        private static readonly string connectionString = @"Data Source=DESKTOP-7AF8POM;Initial Catalog=SistemaGestion;Integrated Security=True";

        public static List<Empleados> CargarEmpleados()
        {
            List<Empleados> _lista = new List<Empleados>();
            string _sente = "SELECT id_Empleado,Nombre,Apellido,Direccion,Comentario,Fecha_Ingreso,password,mail FROM Empleados";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(_sente, conexion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var emp = new Empleados();
                                    emp.Id_Empleado = dr["id_Empleado"] is DBNull ? 0 : Convert.ToInt32(dr["id_Empleado"]);
                                    emp.nombre = dr["Nombre"] is DBNull ? "" : dr["Nombre"].ToString();
                                    emp.apellido = dr["Apellido"] is DBNull ? "" : dr["Apellido"].ToString();
                                    emp.direccion = dr["Direccion"] is DBNull ? "" : dr["Direccion"].ToString();
                                    emp.comentario = dr["Comentario"] is DBNull ? "" : dr["Comentario"].ToString();
                                    emp.fecha_ingreso = dr["Fecha_Ingreso"] is DBNull ? 0 : Convert.ToInt32(dr["Fecha_Ingreso"]);
                                    emp.Password = dr["password"] is DBNull ? "" : dr["password"].ToString();
                                    emp.Mail = dr["mail"] is DBNull ? "" : dr["mail"].ToString();
                                    _lista.Add(emp);
                                }
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
             return _lista;      
        
        }
        public static void insertarEmpleado(Empleados emp)
        {
            var query = "INSERT INTO Empleados(Nombre,Apellido,Direccion,Comentario,Fecha_Ingreso,password,mail) VALUES (@Nombre,@Apellido,@Direccion,@Comentario,@Fecha_Ingreso,@password,@mail)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand(query, con))
                    {

                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = emp.nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = emp.apellido });
                        comando.Parameters.Add(new SqlParameter("Direccion", SqlDbType.VarChar) { Value = emp.direccion });
                        comando.Parameters.Add(new SqlParameter("Comentario", SqlDbType.VarChar) { Value = emp.comentario });
                        comando.Parameters.Add(new SqlParameter("Fecha_Ingreso", SqlDbType.VarChar) { Value = emp.fecha_ingreso });
                        comando.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar) { Value = emp.Password });
                        comando.Parameters.Add(new SqlParameter("mail", SqlDbType.VarChar) { Value = emp.Mail });
                        comando.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void modificarEmpleados(Empleados emp)
        {
            var query = "Update Empleados SET Nombre =  @Nombre, Apellido = @Apellido, Direccion = @Direccion, Comentario = @Comentario, Fecha_Ingreso = @Fecha_Ingreso,password = @password ,mail = @mail WHERE id_Empleado = @id_Empleado ";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand(query, con))
                    {
                        comando.Parameters.Add(new SqlParameter("id_Empleado", SqlDbType.Int) { Value = emp.Id_Empleado });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = emp.nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = emp.apellido });
                        comando.Parameters.Add(new SqlParameter("Direccion", SqlDbType.VarChar) { Value = emp.direccion });
                        comando.Parameters.Add(new SqlParameter("Comentario", SqlDbType.VarChar) { Value = emp.comentario });
                        comando.Parameters.Add(new SqlParameter("Fecha_Ingreso", SqlDbType.Int ){ Value = emp.fecha_ingreso });
                        comando.Parameters.Add(new SqlParameter("password", SqlDbType.VarChar) { Value = emp.Password });
                        comando.Parameters.Add(new SqlParameter("mail", SqlDbType.VarChar) { Value = emp.Mail });

                        comando.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void EliminarEmpleado(int id_Empleado)
        {
            var query = "DELETE FROM Empleados WHERE id_Empleado = @id_Empleado ";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand(query, con))
                    {
                        comando.Parameters.Add(new SqlParameter("id_Empleado", SqlDbType.Int) { Value = id_Empleado });
                        comando.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static Empleados ObtenerUsuarioxId(int id_Empleado)
        {
            Empleados emp = new Empleados();

            string _sente = "SELECT id_Empleado,Nombre,Apellido,Direccion,Comentario,Fecha_Ingreso,password,mail FROM Empleados WHERE id_Empleado = @id_Empleado ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(_sente, conexion))
                    {
                        command.Parameters.Add(new SqlParameter("id_Empleado", SqlDbType.Int) { Value = id_Empleado });

                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    emp.Id_Empleado = dr["id_Empleado"] is DBNull ? 0 : Convert.ToInt32(dr["id_Empleado"]);
                                    emp.nombre = dr["Nombre"] is DBNull ? "" : dr["Nombre"].ToString();
                                    emp.apellido = dr["Apellido"] is DBNull ? "" : dr["Apellido"].ToString();
                                    emp.direccion = dr["Direccion"] is DBNull ? "" : dr["Direccion"].ToString();
                                    emp.comentario = dr["Comentario"] is DBNull ? "" : dr["Comentario"].ToString();
                                    emp.direccion = dr["Direccion"] is DBNull ? "" : dr["Direccion"].ToString();
                                    emp.fecha_ingreso = dr["Fecha_Ingreso"] is DBNull ? 0 : Convert.ToInt32(dr["Fecha_Ingreso"]);
                                    emp.Mail = dr["mail"] is DBNull ? "" : dr["mail"].ToString();

                                }
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return emp;
        }



    }
}
