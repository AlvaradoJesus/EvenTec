using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Calificaciones
    {
        public int idUsuario;
        public int idPublicacion;
        public float Calificacion;
        public Calificaciones() { }
        public Calificaciones(int id, int idp, float cal)
        {
            idUsuario = id;
            idPublicacion = idp;
            Calificacion = cal;
        }
    }
}