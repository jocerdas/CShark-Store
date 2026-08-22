using System;
using System.Collections.Generic;
using System.Text;

namespace CapaModelo
{
    public class ModeloVenta
    {
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public string MetodoPago { get; set; }
        public decimal Total { get; set; }

        // Relación con detalles
        public List<ModeloDetalleVenta> Detalles { get; set; }

        public ModeloVenta()
        {
            Detalles = new List<ModeloDetalleVenta>();
        }

        public ModeloVenta(int idUsuario, string metodoPago, decimal total)
        {
            IdUsuario = idUsuario;
            MetodoPago = metodoPago;
            Total = total;
            FechaVenta = DateTime.Now;
            Detalles = new List<ModeloDetalleVenta>();
        }
    }
}
