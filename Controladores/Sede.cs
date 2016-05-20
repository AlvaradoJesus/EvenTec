using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenTec
{
    public class Sede
    {
        public int idSede;
        public string Nombre;
        public string Calle;
        public string Colonia;
        private string TelefonoO;
        private string CorreoE;
        private string NombreContacto;
        public Sede() { }
        public Sede(int id, string nom, string cal, string col, string tel, string cor, string nomc)
        {
            idSede = id;
            Nombre = nom;
            Calle = cal;
            Colonia = col;
            TelefonoO = tel;
            CorreoE = cor;
            NombreContacto = nomc;
        }
    }
}