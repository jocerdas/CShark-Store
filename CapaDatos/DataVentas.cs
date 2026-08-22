using CapaModelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataVentas
    {
        string conexion = Conexion.ObtenerConexion();

        public int CrearVenta(ModeloVenta venta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_Venta_Crear", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                    cmd.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                    cmd.Parameters.AddWithValue("@Total", venta.Total);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la venta: " + ex.Message);
            }
        }
        public DataTable ListarVentas()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_Venta_Listar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar ventas: " + ex.Message);
            }
            return tabla;
        }

        public decimal ObtenerTotalPorId(int idVenta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_TotalVentaPorId", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener total de venta: " + ex.Message);
            }
        }
        public void ActualizarTotalVenta(int idVenta, decimal total)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Ventas SET Total = @Total WHERE IdVenta = @IdVenta", conn);
                    cmd.Parameters.AddWithValue("@Total", total);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar total de venta: " + ex.Message);
            }
        }
    }
}
