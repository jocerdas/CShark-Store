using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class NegocioArticulo
    {
        private  DataArticulos data = new DataArticulos();
        public DataTable ListarArticulos()
        {
            return data.Listar();
        }

        public bool CrearArticulo(ModeloArticulo articulo)
        {
            if (string.IsNullOrWhiteSpace(articulo.Codigo) || string.IsNullOrWhiteSpace(articulo.Nombre))
                throw new Exception("Debe llenar todos los campos.");

            articulo.IdEstado = articulo.IdEstado == 0 ? 1 : articulo.IdEstado;
            return data.Insertar(articulo);
        }

        public bool ModificarArticulo(ModeloArticulo articulo)
        {
            if (articulo.IdArticulo <= 0)
                throw new Exception("Debe seleccionar un artículo válido.");

            articulo.IdEstado = articulo.IdEstado == 0 ? 1 : articulo.IdEstado;
            return data.Actualizar(articulo);
        }
    }
}
