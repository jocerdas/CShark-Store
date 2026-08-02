using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataDetalleVenta
    {
        public DataTable ObtenerDetalleVentaPorId(int idVenta)
        {
            string conexion = Conexion.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(conexion))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DetalleVentaPorId", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el detalle de venta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }
    }
}
