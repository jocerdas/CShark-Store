using CapaModelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class DataArticulos
    {
        string conexion = Conexion.ObtenerConexion();

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_Articulo_Listar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar artículos: " + ex.Message);
            }
            return tabla;
        }

        public bool Insertar(ModeloArticulo articulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_Articulo_Insertar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", articulo.Precio);
                    cmd.Parameters.AddWithValue("@Stock", articulo.Stock);
                    cmd.Parameters.AddWithValue("@IdEstado", articulo.IdEstado);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar artículo: " + ex.Message);
            }
        }

        public bool Actualizar(ModeloArticulo articulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand("sp_Articulo_Actualizar", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                    cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", articulo.Precio);
                    cmd.Parameters.AddWithValue("@Stock", articulo.Stock);
                    cmd.Parameters.AddWithValue("@IdEstado", articulo.IdEstado);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar artículo: " + ex.Message);
            }
        }
    }
}
