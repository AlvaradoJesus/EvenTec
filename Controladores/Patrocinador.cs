using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Patrocinador
    {
        public int idPatrocinador;
        public string Nombre;
        private string TelefonoO;
        private string TelefonoC;
        private string CorreoE;
        private string NombreContacto;
         public Patrocinador() { }
        public Patrocinador(int id, string nom, string tel, string telc, string cor, string nomc)
        {
            idPatrocinador = id;
            Nombre = nom;            
            TelefonoO = tel;
            TelefonoC = telc;
            CorreoE = cor;
            NombreContacto = nomc;        
        }
    }
}