using CapaModelo;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class MantenimientoArticulos : Form
    {
        public MantenimientoArticulos()
        {
            InitializeComponent();
            CargarArticulos();
            btnModificar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio frmInicio = new Inicio();
            frmInicio.Show();
            this.Hide();
        }
        private NegocioArticulo negocio = new NegocioArticulo();
        private ModeloArticulo articuloSeleccionado = null;

        private void CargarArticulos()
        {
            try
            {
                dgvArticulos.DataSource = negocio.ListarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            chkActivo.Checked = false;
            articuloSeleccionado = null;
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                ModeloArticulo nuevo = new ModeloArticulo
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    IdEstado = chkActivo.Checked ? 1 : 2
                };

                bool resultado = negocio.CrearArticulo(nuevo);

                if (resultado)
                {
                    MessageBox.Show("Artículo creado correctamente.");
                    CargarArticulos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear artículo: " + ex.Message);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (articuloSeleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar un artículo primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                articuloSeleccionado.Nombre = txtNombre.Text;
                articuloSeleccionado.Precio = Convert.ToDecimal(txtPrecio.Text);
                articuloSeleccionado.Stock = Convert.ToInt32(txtStock.Text);
                articuloSeleccionado.IdEstado = chkActivo.Checked ? 1 : 2;

                bool resultado = negocio.ModificarArticulo(articuloSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Artículo modificado correctamente.");
                    CargarArticulos();
                    LimpiarCampos();
                    btnModificar.Enabled = false;
                    articuloSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar artículo: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dgvArticulos.SelectedRows[0];

                    articuloSeleccionado = new ModeloArticulo
                    {
                        IdArticulo = Convert.ToInt32(fila.Cells["IdArticulo"].Value),
                        Codigo = fila.Cells["Codigo"].Value.ToString(),
                        Nombre = fila.Cells["Nombre"].Value.ToString(),
                        Precio = Convert.ToDecimal(fila.Cells["Precio"].Value),
                        Stock = Convert.ToInt32(fila.Cells["Stock"].Value),
                        IdEstado = fila.Cells["NombreEstado"].Value.ToString() == "Activo" ? 1 : 2
                    };

                    // Pasar datos a los controles
                    txtCodigo.Text = articuloSeleccionado.Codigo;
                    txtNombre.Text = articuloSeleccionado.Nombre;
                    txtPrecio.Text = articuloSeleccionado.Precio.ToString();
                    txtStock.Text = articuloSeleccionado.Stock.ToString();
                    chkActivo.Checked = articuloSeleccionado.IdEstado == 1;

                    btnModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar artículo: " + ex.Message);
            }
        }
    }
}
