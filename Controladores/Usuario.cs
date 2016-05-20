using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenTec
{
    public class Usuarios
    {
        public int idUsuario;
        public string Usuario;
        private string Contraseña;
        public Usuarios() { }
        public Usuarios(int id, string usu, string con)
        {
            idUsuario = id;
            Usuario = usu;
            Contraseña = con;
        }
    }
}