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
    public partial class MantenimientoUsuarios : Form
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            NegocioUsuario negocio = new NegocioUsuario();

            // Mostrar conteo de usuarios nuevos
            int conteo = negocio.ObtenerConteoUsuariosNuevos();
            lblConteo.Text = conteo.ToString();

            // Activar o desactivar el botón según conteo
            btnNuevos.Enabled = conteo > 0;

            // Cargar todos los usuarios en el DataGrid
            dgvUsuarios.DataSource = negocio.ObtenerTodosUsuarios();

            btnSeleccionar.Enabled = true;
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = dgvUsuarios.SelectedRows.Count > 0;
        }

        private int usuarioSeleccionadoId = 0;

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario en el grid.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvUsuarios.SelectedRows[0];
            usuarioSeleccionadoId = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

            mskCedula.Text = fila.Cells["Cedula"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            txtContrasena.Clear(); // nunca mostrar contraseña

            // Rol
            string rol = fila.Cells["NombreRol"].Value.ToString();
            rbAdministrador.Checked = rol == "Administrador";
            rbEjecutivo.Checked = rol == "Ejecutivo";
            rbCliente.Checked = rol == "Cliente";

            // Estado
            string estado = fila.Cells["NombreEstado"].Value.ToString();
            chkActivo.Checked = estado == "Activo";
            chkNuevo.Checked = estado == "Nuevo";

            // Ajustar botones
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Todos los campos son obligatorios y debe seleccionar un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NegocioUsuario negocio = new NegocioUsuario();
            bool actualizado = negocio.ModificarUsuario(
                usuarioSeleccionadoId,
                mskCedula.Text,
                txtNombre.Text,
                txtApellidos.Text,
                txtUsuario.Text,
                txtContrasena.Text, // se guarda lo que se ingrese
                ObtenerRolSeleccionado(),
                chkActivo.Checked ? 1 : 2
            );

            if (actualizado)
            {
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarGridYConteo();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGuardar.Enabled = true;
        }

        private void btnNuevos_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocio = new NegocioUsuario();
            DataTable dt = negocio.ObtenerUsuarioNuevo();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios nuevos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNuevos.Enabled = false;
                return;
            }

            DataRow fila = dt.Rows[0];
            mskCedula.Text = fila["Cedula"].ToString();
            txtNombre.Text = fila["Nombre"].ToString();
            txtApellidos.Text = fila["Apellidos"].ToString();
            txtUsuario.Text = fila["Usuario"].ToString();
            txtContrasena.Clear();

            rbCliente.Checked = true;
            chkNuevo.Checked = true;

            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(mskCedula.Text)
                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtApellidos.Text)
                && !string.IsNullOrWhiteSpace(txtUsuario.Text)
                && (rbAdministrador.Checked || rbEjecutivo.Checked || rbCliente.Checked);
        }

        private int ObtenerRolSeleccionado()
        {
            if (rbAdministrador.Checked) return 1;
            if (rbEjecutivo.Checked) return 2;
            return 3;
        }

        private void LimpiarCampos()
        {
            mskCedula.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            rbAdministrador.Checked = rbEjecutivo.Checked = rbCliente.Checked = false;
            chkActivo.Checked = chkNuevo.Checked = false;

            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void ActualizarGridYConteo()
        {
            NegocioUsuario negocio = new NegocioUsuario();
            dgvUsuarios.DataSource = negocio.ObtenerTodosUsuarios();

            int conteo = negocio.ObtenerConteoUsuariosNuevos();
            lblConteo.Text = conteo.ToString();
            btnNuevos.Enabled = conteo > 0;
        }
        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                chkNuevo.Checked = false;
            }
        }
        private void chkNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevo.Checked)
            {
                chkActivo.Checked = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio frmInicio = new Inicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios, incluyendo la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NegocioUsuario negocio = new NegocioUsuario();
            string mensaje = negocio.GuardarUsuario(
                mskCedula.Text,
                txtNombre.Text,
                txtApellidos.Text,
                txtUsuario.Text,
                txtContrasena.Text,
                ObtenerRolSeleccionado(),
                chkActivo.Checked ? 1 : 2 // Estado: Activo o Inactivo
            );

            MessageBox.Show(mensaje, "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Contains("correctamente"))
            {
                LimpiarCampos();
                ActualizarGridYConteo();
            }
        }
    }
}
