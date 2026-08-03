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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioUsuario negocio = new NegocioUsuario();

                string mensaje = negocio.RegistrarNuevoUsuario(
                    mskCedula.Text,
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtUsuario.Text,
                    txtContrasena.Text
                );

                MessageBox.Show(mensaje, "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mensaje.Contains("correctamente"))
                {
                    // Limpiar campos
                    mskCedula.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
