using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataUsuarios
    {
        public DataTable ValidarLogin(string usuario, string contrasena)
        {
            string conexion = Conexion.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(conexion))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_Usuario_Login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar el login: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }

        public bool UsuarioExiste(string usuario)
        {
            string conexion = Conexion.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(conexion))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE Usuario = @Usuario", conn);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar existencia del usuario: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }

        public bool RegistrarUsuario(string cedula, string nombre, string apellidos, string usuario, string contrasena)
        {
            string conexion = Conexion.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(conexion))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_Usuario_Insertar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@IdRol", 3);     // Rol fijo
                    cmd.Parameters.AddWithValue("@IdEstado", 3);  // Estado fijo

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar usuario: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }
    }
}
