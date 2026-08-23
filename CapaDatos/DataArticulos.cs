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
                            (Codigo, Nombre, Precio, Stock, IdEstado, FechaCreacion)
                            VALUES
                            (@Codigo, @Nombre, @Precio, @Stock, @IdEstado, @FechaCreacion)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
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

        public DataTable ObtenerArticulos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                string consulta = @"SELECT 
                                        I.IdArticulo,
                                        I.Codigo,
                                        I.Nombre,
                                        I.Precio,
                                        I.Stock,
                                        I.IdEstado,
                                        E.NombreEstado AS Estado,
                                        I.FechaCreacion
                                    FROM Inventario I
                                    INNER JOIN C_Estado E
                                        ON I.IdEstado = E.IdEstado
                                    ORDER BY I.IdArticulo";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        public bool ModificarArticulo(Articulo articulo)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                string consulta = @"UPDATE Inventario
                            SET Codigo = @Codigo,
                                Nombre = @Nombre,
                                Precio = @Precio,
                                Stock = @Stock,
                                IdEstado = @IdEstado
                            WHERE IdArticulo = @IdArticulo";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                    comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                    comando.Parameters.AddWithValue("@Stock", articulo.Stock);
                    comando.Parameters.AddWithValue("@IdEstado", articulo.IdEstado);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
