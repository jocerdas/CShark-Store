using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
