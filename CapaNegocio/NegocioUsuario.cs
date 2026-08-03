using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private DataUsuarios dataUsuarios = new DataUsuarios();

        public (bool valido, string mensaje, string rol, string usuario) ValidarUsuario(string usuario, string contrasena)
        {
            var dt = dataUsuarios.ValidarLogin(usuario, contrasena);

            // Si no hay registros, usuario o contraseña incorrectos
            if (dt.Rows.Count == 0)
                return (false, "Usuario o contraseña incorrectos.", null, null);

            // Extraer datos
            var estado = Convert.ToInt32(dt.Rows[0]["IdEstado"]);
            var rol = dt.Rows[0]["NombreRol"].ToString();
            var nombreUsuario = dt.Rows[0]["Usuario"].ToString();

            // Validar estado
            if (estado != 1)
                return (false, "Usuario inactivo. Valídelo con el administrador.", null, null);

            // Si todo está correcto
            return (true, $"Bienvenido {nombreUsuario}. Rol: {rol}", rol, nombreUsuario);
        }

        public string RegistrarNuevoUsuario(string cedula, string nombre, string apellidos, string usuario, string contrasena)
        {
            if (dataUsuarios.UsuarioExiste(usuario))
                return "El usuario ya existe. Por favor, ingrese un nombre de usuario diferente.";

            bool registrado = dataUsuarios.RegistrarUsuario(cedula, nombre, apellidos, usuario, contrasena);

            return registrado
                ? "Usuario registrado correctamente."
                : "No se pudo registrar el usuario. Intente nuevamente.";
        }
    }
}
