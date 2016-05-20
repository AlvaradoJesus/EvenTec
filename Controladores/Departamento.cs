using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Departamento
    {
        public int idDepartamento;
        public string Nombre;
        private int Descripcion;
        public Departamento() { }
        public Departamento(int id, string nom, int des)
        {
            idDepartamento = id;
            Nombre = nom;
            Descripcion = des;
        }
    }
}