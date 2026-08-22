using System;
using System.Collections.Generic;
using System.Text;

namespace CapaModelo
{
    public class ModeloUsuario
    {
        private int IdUsuario;
        private string Cedula;
        private string Nombre;
        private string Apellidos;
        private string Usuario;
        private string Contrasena;
        private int IdRol;
        private string Rol;
        private int IdEstado;
        private string Estado;
        public ModeloUsuario() { }

        public ModeloUsuario(int idUsuario, string cedula, string nombre, string apellidos, string usuario, string contraseña, int idRol, string rol, int idEstado, string estado)
        {
            IdUsuario = idUsuario;
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            Usuario = usuario;
            Contrasena = contraseña;
            IdRol = idRol;
            Rol = rol;
            IdEstado = idEstado;
            Estado = estado;
        }
        //Propiedades Públicas
        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        public string cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string contrasena
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }
        public int idRol
        {
            get { return IdRol; }
            set { IdRol = value; }
        }
        public string rol
        {
            get { return Rol; }
            set { Rol = value; }
        }
        public int idEstado
        {
            get { return IdEstado; }
            set { IdEstado = value; }
        }
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

    }
}
