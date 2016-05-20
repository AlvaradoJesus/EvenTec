using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Notificacion
    {
        public int idNotificacion;
        public int idCategoria;
        public Notificacion() { }
        public Notificacion(int id, int idc)
        {
            idNotificacion = id;
            idCategoria = idc;
        }
    }
}