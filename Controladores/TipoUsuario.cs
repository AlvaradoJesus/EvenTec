using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class TipoUsuarios
    {
        public int idTipoUsuario;
        public string TipoUsuario;
        private string Descripcion;
        public TipoUsuarios() { }
        public TipoUsuarios(int id, string tip, string des)
        {
            idTipoUsuario = id;
            TipoUsuario = tip;
            Descripcion = des;
        }
    }
}