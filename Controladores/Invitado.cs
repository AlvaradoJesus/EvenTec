using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenTec
{
    public class Invitado
    {
        public int idInvitado;
        public string Nombre;
        private string ApellidoP;
        private string ApellidoM;
        private int TelefonoO;
        private string TelefonoC;
        private string CorreoE;
        public Invitado() { }
        public Invitado(int id, string nom, string ap, string am, int tel, string telc, string cor)
        {
            idInvitado = id;
            Nombre = nom;
            ApellidoP = ap;
            ApellidoM = am;
            TelefonoO = tel;
            TelefonoC = telc;
            CorreoE = cor;
        }
    }
}