using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Publicacion
    {
        public int idPublicacion;
        public int idEvento;
        public int CRegistros;
        public float Calificacion;
        public int idUsuario;
        public Publicacion() { }
        public Publicacion(int id, int ide, int reg, float cal, int idu)
        {
            idPublicacion = id;
            idEvento = ide;
            CRegistros = reg;
            Calificacion = cal;
            idUsuario = idu;
        }
    }
}