using System;
using System.Collections.Generic;
using System.Text;

namespace CapaModelo
{
    public class ModeloArticulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ModeloArticulo() { }

        public ModeloArticulo(int idArticulo, string codigo, string nombre, decimal precio, int stock, int idEstado)
        {
            IdArticulo = idArticulo;
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            IdEstado = idEstado;
        }
    }
}
