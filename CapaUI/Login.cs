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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var negocio = new NegocioUsuario();
                var resultado = negocio.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);

                if (!resultado.valido)
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Global.UsuarioActual = resultado.usuario;
                Global.RolActual = resultado.rol;

                MessageBox.Show(resultado.mensaje, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Inicio frmInicio = new Inicio();
                frmInicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.Show();
            this.Hide();
        }
    }
}
