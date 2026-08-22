using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class NegocioVenta
    {
        private  DataVentas data = new DataVentas();

        public int CrearVenta(ModeloVenta venta)
        {
            if (venta == null)
                throw new Exception("La venta no puede ser nula.");

            // Permitir crear la venta con total 0, pero no negativa
            if (venta.Total < 0)
                throw new Exception("El total de la venta no puede ser negativo.");

            return data.CrearVenta(venta);
        }

        public DataTable ListarVentas()
        {
            return data.ListarVentas();
        }

        public decimal ObtenerTotalPorId(int idVenta)
        {
            if (idVenta <= 0)
                throw new Exception("Debe proporcionar un ID de venta válido.");

            return data.ObtenerTotalPorId(idVenta);
        }

        public void ActualizarTotalVenta(int idVenta, decimal total)
        {
            if (idVenta <= 0)
                throw new Exception("El ID de venta no es válido.");

            if (total < 0)
                throw new Exception("El total no puede ser negativo.");

            data.ActualizarTotalVenta(idVenta, total);
        }
    }
}
