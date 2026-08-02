using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public static class Global
    {
        // Usuario actual logueado
        public static string UsuarioActual { get; set; }

        // Rol del usuario
        public static string RolActual { get; set; }

        // Id del usuario
        public static int IdUsuarioActual { get; set; }

        // Si quieres guardar también el estado
        public static int EstadoUsuarioActual { get; set; }
    }
}
