using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Alumno
    {
        public int idUsuario;
        public int Nombre;
        private string ApellidoP;
        private string ApellidoM;
        public int idDepartamento;
        public int idCarrera;
        private string NumControl;
        private string FechaN;
        private string CorreoE;
          public Alumno(int id, int nom, string ap, string am, int dep, int idc, string num, string fec, string correo)
        {
            idUsuario = id;
            Nombre = nom;
            ApellidoP = ap;
            ApellidoM = am;
            idDepartamento = dep;
            CorreoE = correo;
            idCarrera = idc;
            NumControl = num;
            FechaN = fec;
        }
          public Alumno() { }
    }
}