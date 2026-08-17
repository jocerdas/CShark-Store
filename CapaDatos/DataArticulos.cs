using CapaEntidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class DataArticulos
    {
        public bool InsertarArticulo(Articulo articulo)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                string consulta = @"INSERT INTO Inventario
                            (IdArticulo, Codigo, Nombre, Precio, Stock, IdEstado, FechaCreacion)
                            VALUES
                            (@IdArticulo, @Codigo, @Nombre, @Precio, @Stock, @IdEstado, @FechaCreacion)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                    comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                    comando.Parameters.AddWithValue("@Stock", articulo.Stock);
                    comando.Parameters.AddWithValue("@IdEstado", articulo.IdEstado);
                    comando.Parameters.AddWithValue("@FechaCreacion", articulo.FechaCreacion);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
