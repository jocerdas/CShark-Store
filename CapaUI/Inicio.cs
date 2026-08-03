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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ConfigurarMenuPorRol()
        {
            // Bloquear Inventario para todos
            btnRInventario.Enabled = false;

            switch (Global.RolActual)
            {
                case "Administrador":
                case "1":
                    btnRTienda.Enabled = false;
                    btnRMantUsuarios.Enabled = true;
                    btnRMantArticulos.Enabled = true;
                    break;

                case "Ejecutivo":
                case "2":
                    btnRTienda.Enabled = true;
                    btnRMantUsuarios.Enabled = false;
                    btnRMantArticulos.Enabled = true;
                    break;

                case "Cliente":
                case "3":
                    btnRTienda.Enabled = false;
                    btnRMantUsuarios.Enabled = false;
                    btnRMantArticulos.Enabled = false;
                    break;

                default:
                    MessageBox.Show("Rol no reconocido. Contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ConfigurarMenuPorRol();
            lblUsuarioActivo.Text = $"Usuario: {Global.UsuarioActual} - Rol: {Global.RolActual}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Limpiar variables globales
            Global.UsuarioActual = null;
            Global.RolActual = null;
            Global.IdUsuarioActual = 0;
            Global.EstadoUsuarioActual = 0;

            // Volver al Login
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRTienda_Click(object sender, EventArgs e)
        {
            Tienda frmTienda = new Tienda();
            frmTienda.Show();
            this.Hide();
        }

        private void btnRMantUsuarios_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios frmMantenimientoUsuarios = new MantenimientoUsuarios();
            frmMantenimientoUsuarios.Show();
            this.Hide();
        }

        private void btnRMantArticulos_Click(object sender, EventArgs e)
        {
            MantenimientoArticulos frmMantenimientoArticulos = new MantenimientoArticulos();
            frmMantenimientoArticulos.Show();
            this.Hide();
        }
    }
}
