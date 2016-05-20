using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Organizador
    {
        public int idUsuario;
        public string Nombre;
        private string ApellidoP;
        private string ApellidoM;
        private string TelefonoO;
        private string TelefonoC;
        private string CorreoE;
        public Organizador() { }
        public Organizador(int id, string nom, string ap, string am, string tel, string telc, string cor)
        {
            idUsuario = id;
            Nombre = nom;
            ApellidoP = ap;
            ApellidoM = am;
            TelefonoO = tel;
            TelefonoC = telc;
            CorreoE = cor;
        
        }
    }
}