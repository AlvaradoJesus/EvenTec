using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EvenTec
{
    public class Administrador
    {
        public int idUsuario;
        public int Nombre;
        private string ApellidoP;
        private string ApellidoM;
        public int idDepartamento;
        private string CorreoE;
        public Administrador() { }
        public Administrador(int id, int nom, string ap, string am, int dep, string correo)
        {
            idUsuario = id;
            Nombre = nom;
            ApellidoP = ap;
            ApellidoM = am;
            idDepartamento = dep;
            CorreoE = correo;
        }
    }
}