using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Comentarios
    {
        public int idPublicacion;
        public int idUsuario;
        public string Comentario;
        public string Fecha;
        public Comentarios() { }
        public Comentarios(int id, int idu, string com, string fec)
        {
            idPublicacion = id;
            idUsuario = idu;
            Comentario = com;
            Fecha = fec;
        }
    }
}