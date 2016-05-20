using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Categorias
    {
        public int idCategoria;
        public string Categoria;
        private string Descripcion;
        public Categorias() { }
        public Categorias(int id, string cat, string des)
        {
            idCategoria = id;
            Categoria = cat;
            Descripcion = des;
        }
    }
}