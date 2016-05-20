using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenTec
{
    public class Carrera
    {
        public int idCarrera;
        public int idDepartamento;
        public string Nombre;
        private string Descripcion;
        public Carrera() { }
        public Carrera(int id, int idp, string nom, string des)
        {
            idCarrera = id;
            idDepartamento = idp;
            Nombre = nom;
            Descripcion = des;
        }
    }
}