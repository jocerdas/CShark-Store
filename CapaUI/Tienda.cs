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
    public partial class Tienda : Form
    {
        private NegocioArticulo negocioArticulo = new NegocioArticulo();
        private NegocioVenta negocioVenta = new NegocioVenta();
        private NegocioDetalleVenta negocioDetalle = new NegocioDetalleVenta();

        private int idVentaActual = 0;
        private List<ModeloDetalleVenta> listaDetalles = new List<ModeloDetalleVenta>();
        public Tienda()
        {
            InitializeComponent();
            CargarArticulos();
            ConfigurarControles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio frmInicio = new Inicio();
            frmInicio.Show();
            this.Hide();
        }

        private void ConfigurarControles()
        {
            txtCodigo.Enabled = false;
            txtPrecioTotal.Enabled = false;
            txtTotalFacturar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            cbxNombreArticulo.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecioUnitario.Enabled = false;
        }

        private void CargarArticulos()
        {
            try
            {
                DataTable dt = negocioArticulo.ListarArticulos();
                List<ModeloArticulo> lista = new List<ModeloArticulo>();

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new ModeloArticulo
                    {
                        IdArticulo = Convert.ToInt32(row["IdArticulo"]),
                        Codigo = row["Codigo"].ToString(),
                        Nombre = row["Nombre"].ToString(),
                        Precio = Convert.ToDecimal(row["Precio"])
                    });
                }

                comboHelper.CargarCombo(cbxNombreArticulo, lista, "Nombre", "IdArticulo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }

        private void cbxNombreArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxNombreArticulo.SelectedIndex > 0)
                {
                    ModeloArticulo articulo = comboHelper.ObtenerSeleccionado<ModeloArticulo>(cbxNombreArticulo);

                    if (articulo != null)
                    {
                        txtCodigo.Text = articulo.Codigo;
                        txtPrecioUnitario.Text = articulo.Precio.ToString("0.00");
                        txtCodigo.Enabled = false;
                        txtPrecioUnitario.Enabled = false;
                        btnAgregar.Enabled = true;
                    }
                }
                else
                {
                    txtCodigo.Clear();
                    txtPrecioUnitario.Clear();
                    btnAgregar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar artículo: " + ex.Message);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtPrecioUnitario.Text, out decimal precio) &&
                    int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    txtPrecioTotal.Text = (precio * cantidad).ToString("0.00");
                }
                else
                {
                    txtPrecioTotal.Clear();
                }
            }
            catch { }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxNombreArticulo.SelectedIndex <= 0)
                    throw new Exception("Debe seleccionar un artículo.");

                if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                    throw new Exception("Debe ingresar la cantidad.");

                if (!rbEfectivo.Checked && !rbTarjeta.Checked && !rbTransferencia.Checked)
                    throw new Exception("Debe seleccionar un método de pago.");

                ModeloArticulo articulo = (ModeloArticulo)cbxNombreArticulo.SelectedItem;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);

                // Generar NuevaLinea incremental
                int nuevaLinea = listaDetalles.Count + 1;

                ModeloDetalleVenta detalle = new ModeloDetalleVenta
                {
                    IdVenta = idVentaActual,
                    LineaDetalle = nuevaLinea,
                    IdArticulo = articulo.IdArticulo,
                    CodigoArticulo = articulo.Codigo,
                    NombreArticulo = articulo.Nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                    PrecioTotal = cantidad * precioUnitario                    
                };

                listaDetalles.Add(detalle);
                ActualizarGrid();
                CalcularTotalFacturar();

                LimpiarCamposArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar artículo: " + ex.Message);
            }
        }
        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDetalles;

            // Ocultar columnas internas
            dataGridView1.Columns["IdDetalle"].Visible = false;
            dataGridView1.Columns["IdArticulo"].Visible = false;
            dataGridView1.Columns["IdVenta"].Visible = false;

            // Reordenar columnas visibles
            dataGridView1.Columns["LineaDetalle"].DisplayIndex = 0;
            dataGridView1.Columns["CodigoArticulo"].DisplayIndex = 1;
            dataGridView1.Columns["NombreArticulo"].DisplayIndex = 2;
            dataGridView1.Columns["Cantidad"].DisplayIndex = 3;
            dataGridView1.Columns["PrecioUnitario"].DisplayIndex = 4;
            dataGridView1.Columns["PrecioTotal"].DisplayIndex = 5;

            // Encabezados más legibles
            dataGridView1.Columns["LineaDetalle"].HeaderText = "Línea";
            dataGridView1.Columns["CodigoArticulo"].HeaderText = "Código";
            dataGridView1.Columns["NombreArticulo"].HeaderText = "Artículo";
            dataGridView1.Columns["Cantidad"].HeaderText = "Cantidad";
            dataGridView1.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dataGridView1.Columns["PrecioTotal"].HeaderText = "Precio Total";
        }
        private void CalcularTotalFacturar()
        {
            decimal total = 0;
            foreach (var item in listaDetalles)
                total += item.PrecioTotal;

            txtTotalFacturar.Text = total.ToString("0.00");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una línea para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int index = dataGridView1.SelectedRows[0].Index;
                listaDetalles.RemoveAt(index);

                // Recalcular líneas
                for (int i = 0; i < listaDetalles.Count; i++)
                {
                    listaDetalles[i].LineaDetalle = i + 1;
                }

                ActualizarGrid();
                CalcularTotalFacturar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar línea: " + ex.Message);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaDetalles.Count == 0)
                    throw new Exception("Debe agregar al menos un artículo.");

                string metodoPago = rbEfectivo.Checked ? "Efectivo" :
                                    rbTarjeta.Checked ? "Tarjeta" : "Transferencia";

                decimal totalVenta = Convert.ToDecimal(txtTotalFacturar.Text);

                // Actualizar total de la venta existente
                negocioVenta.ActualizarTotalVenta(idVentaActual, totalVenta);

                // Insertar detalles
                foreach (var detalle in listaDetalles)
                {
                    detalle.IdVenta = idVentaActual;
                    int idDetalleGenerado = negocioDetalle.InsertarDetalle(detalle);
                    detalle.IdDetalle = idDetalleGenerado; // sincroniza el modelo con el ID real
                }

                MessageBox.Show("Venta registrada correctamente. ID Venta: " + idVentaActual);
                btnVolver.Enabled = true;
                btnFacturar.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                cbxNombreArticulo.Enabled = false;
                txtCantidad.Enabled = false;
                rbEfectivo.Checked = false;
                rbTarjeta.Checked = false;
                rbTransferencia.Checked = false;

                listaDetalles.Clear();
                ActualizarGrid();
                CalcularTotalFacturar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al facturar: " + ex.Message);
            }
        }

        private void LimpiarCamposArticulo()
        {
            cbxNombreArticulo.SelectedIndex = 0;
            txtCodigo.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtPrecioTotal.Clear();
        }

        private void btnVentaNueva_Click(object sender, EventArgs e)
        {
            try
            {
                string metodoPago = rbEfectivo.Checked ? "Efectivo" :
                                    rbTarjeta.Checked ? "Tarjeta" : "Transferencia";

                ModeloVenta venta = new ModeloVenta
                {
                    IdUsuario = 1, // usuario logueado
                    MetodoPago = metodoPago,
                    Total = 0 // inicia en cero, se actualizará con los detalles
                };

                idVentaActual = negocioVenta.CrearVenta(venta);

                lblIdVenta.Text = "ID de Venta: " + idVentaActual;

                // habilitar controles
                cbxNombreArticulo.Enabled = true;
                txtCantidad.Enabled = true;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnFacturar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar venta: " + ex.Message);
            }
        }
    }
}
