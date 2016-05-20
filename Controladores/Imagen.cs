using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenTec
{
    public class Imagenes
    {
        public int idEvento;
        private string Descripcion;
        public string Imagen;
        public Imagenes() { }
        public Imagenes(int id, string des, string im)
        {
            idEvento = id;
            Descripcion = des;
            Imagen = im;
        }

    }
}