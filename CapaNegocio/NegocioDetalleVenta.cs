using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class NegocioDetalleVenta
    {
        private DataDetalleVenta data = new DataDetalleVenta();

        public int InsertarDetalle(ModeloDetalleVenta detalle)
        {
            if (detalle == null)
                throw new Exception("El detalle de venta no puede ser nulo.");

            if (detalle.IdVenta <= 0 || detalle.IdArticulo <= 0)
                throw new Exception("Debe proporcionar IDs válidos para venta y artículo.");

            if (detalle.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a cero.");

            return data.InsertarDetalle(detalle);
        }

        public DataTable ListarPorIdVenta(int idVenta)
        {
            if (idVenta <= 0)
                throw new Exception("Debe proporcionar un ID de venta válido.");

            return data.ListarPorIdVenta(idVenta);
        }
    }
}
