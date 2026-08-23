using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using CapaDatos;
using CapaEntidades;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class MantenimientoArticulos : Form
    {
        private int idArticuloSeleccionado = 0;
        public MantenimientoArticulos()
        {
            InitializeComponent();

            CargarArticulos();

            chkActivo.Checked = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del artículo.");
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del artículo.");
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico.");
                txtPrecio.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                txtStock.Focus();
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("El stock no puede ser negativo.");
                txtStock.Focus();
                return;
            }

            //Se crea el objeto
            Articulo articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text.Trim();
            articulo.Nombre = txtNombre.Text.Trim();
            articulo.Precio = precio;
            articulo.Stock = stock;
            articulo.IdEstado = 3;
            articulo.FechaCreacion = DateTime.Now;

            //Enviar a capa datos
            DataArticulos datos = new DataArticulos();

            bool resultado = datos.InsertarArticulo(articulo);

            if (resultado)
            {
                MessageBox.Show("Artículo registrado correctamente.");

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                chkActivo.Checked = false;

                CargarArticulos();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el artículo.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio frmInicio = new Inicio();
            frmInicio.Show();
            this.Hide();
        }

        private void CargarArticulos()
        {
            DataArticulos datos = new DataArticulos();

            dgvArticulos.DataSource = datos.ObtenerArticulos();

            dgvArticulos.Columns["IdEstado"].Visible = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un artículo.");
                return;
            }

            idArticuloSeleccionado = Convert.ToInt32(
                dgvArticulos.CurrentRow.Cells["IdArticulo"].Value
            );

            txtCodigo.Text =
                dgvArticulos.CurrentRow.Cells["Codigo"].Value.ToString();

            txtNombre.Text =
                dgvArticulos.CurrentRow.Cells["Nombre"].Value.ToString();

            txtPrecio.Text =
                dgvArticulos.CurrentRow.Cells["Precio"].Value.ToString();

            txtStock.Text =
                dgvArticulos.CurrentRow.Cells["Stock"].Value.ToString();

            int idEstado = Convert.ToInt32(
                dgvArticulos.CurrentRow.Cells["IdEstado"].Value
            );

            // Solo los artículos activos aparecerán con el CheckBox marcado.
            chkActivo.Checked = idEstado == 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idArticuloSeleccionado == 0)
            {
                MessageBox.Show("Primero debe seleccionar un artículo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el código del artículo.");
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del artículo.");
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico.");
                txtPrecio.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                txtStock.Focus();
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("El stock no puede ser negativo.");
                txtStock.Focus();
                return;
            }

            Articulo articulo = new Articulo();

            articulo.IdArticulo = idArticuloSeleccionado;
            articulo.Codigo = txtCodigo.Text.Trim();
            articulo.Nombre = txtNombre.Text.Trim();
            articulo.Precio = precio;
            articulo.Stock = stock;

            if (chkActivo.Checked)
            {
                articulo.IdEstado = 1;
            }
            else
            {
                articulo.IdEstado = 2;
            }

            DataArticulos datos = new DataArticulos();

            bool resultado = datos.ModificarArticulo(articulo);

            if (resultado)
            {
                MessageBox.Show("Artículo modificado correctamente.");

                CargarArticulos();

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                chkActivo.Checked = false;

                idArticuloSeleccionado = 0;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el artículo.");
            }
        }
    }
}
