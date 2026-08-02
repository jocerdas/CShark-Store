using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataVentas
    {
        public decimal ObtenerTotalVentaPorId(int idVenta)
        {
            string conexion = Conexion.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(conexion))
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_TotalVentaPorId", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                    object resultado = cmd.ExecuteScalar();
                    return resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el total de la venta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
        }
    }
}
