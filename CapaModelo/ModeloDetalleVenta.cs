using System;
using System.Collections.Generic;
using System.Text;

namespace CapaModelo
{
    public class ModeloDetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdArticulo { get; set; }
        public string CodigoArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public int LineaDetalle { get; set; }

        public ModeloDetalleVenta() { }

        public ModeloDetalleVenta(int lineaDetalle, int idArticulo, string codigo, string nombre, int cantidad, decimal precioUnitario)
        {
            LineaDetalle = lineaDetalle;
            IdArticulo = idArticulo;
            CodigoArticulo = codigo;
            NombreArticulo = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            PrecioTotal = cantidad * precioUnitario;
        }
    }
}
