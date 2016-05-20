using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenSoft
{
    public class Evento
    {
        public int idEvento;
        public int idDepartamento;
        public int idCarrera;
        public int idSede;
        public string Fecha;
        public string Nombre;
        public int idUsuario;
        public string Descripcion;
        public Evento() { }
        public Evento(int id, int idd, int idc, int ids, string fec, string nom, int idu, string des)
        {
            idEvento = id;
            idDepartamento = idd;
            idCarrera = idc;
            idSede = ids;
            Fecha = fec;
            Nombre = nom;
            idUsuario = idu;
            Descripcion = des;
        }

    }
}