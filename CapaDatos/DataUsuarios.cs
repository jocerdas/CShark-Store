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
    }
}
