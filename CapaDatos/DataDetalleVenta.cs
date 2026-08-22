using CapaModelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataDetalleVenta
    {
        string conexion = Conexion.ObtenerConexion();

        public int InsertarDetalle(ModeloDetalleVenta detalle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_DetalleVenta_Insertar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
                    cmd.Parameters.AddWithValue("@LineaDetalle", detalle.LineaDetalle);
                    cmd.Parameters.AddWithValue("@IdArticulo", detalle.IdArticulo);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);


                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalle de venta: " + ex.Message);
            }
        }

        public DataTable ListarPorIdVenta(int idVenta)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_DetalleVentaPorId", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar detalles de venta: " + ex.Message);
            }
            return tabla;
        }
    }
}
