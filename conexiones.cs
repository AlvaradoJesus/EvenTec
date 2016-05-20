using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EvenTec
{
    class conexiones
    {
        SqlCommand command;
        SqlDataReader leer;
        DataSet dat;
        SqlDataAdapter ada;
        public void CalEvento(string cal)
        {
            //Calificaciones del evento
           
            
            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select Calificacion.Calificacion  from Evento, Calificacion, Publicacion "
                + "where Calificacion.idPublicacion = Publicacion.idPublicacion and Publicacion.idEvento = Evento.idEvento and Evento.idEvento = {0}", cal), connect);
                dat = new DataSet();
                ada.Fill(dat, "calificacion");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "calificacion";
                connect.Close();
            }
           
        }
        public void EventOrg(string org)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento, RegistroEvento, Organizador "
                + "where RegistroEvento.idEvento = Evento.idEvento and RegistroEvento.idUsuario = Organizador.idUsuario and Organizador.idUsuario = {0}", org), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventFecha(string fec)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento where Evento.Fecha = {0}", fec), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventNom(string nom)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento where Evento.Nombre = {0}", nom), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventDep(string dep)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento, Departamento where Departamento.idDepartamento = {0} and evento.idDepartamento = Departamento.idDepartamento ", dep), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventCar(string car)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento, Carrera where Carrera.idCarrera = {0} and evento.idCarrera = Carrera.idCarrera ", car), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventCat(string cat)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento, Publicacion, CategoriaEvento,Categoria where CategoriaEvento.idCategoria = Categoria.idCategoria and CategoriaEvento.idPublicacion = Publicacion.idPublicacion and Publicacion.idEvento = Evento.idEvento and Categoria.idCategoria = {0}", cat), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void EventSed(string sed)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento,Sede where Evento.idSede = Sede.idSede and Sede.idSede = {0}", sed, connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void Carreras()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Carrera"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Carreras");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Carreras";
                connect.Close();
            }

        }
        public void Categorias()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Categoria"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Categorias");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Categorias";
                connect.Close();
            }

        }
        public void Publicaciones()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Publicacion"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Publicaciones");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Publicaciones";
                connect.Close();
            }

        }
        public void Administradores()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Administrador"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Administradores");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Administradores";
                connect.Close();
            }

        }
        public void Departamentos()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Departamento"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Departamentos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Departamentos";
                connect.Close();
            }

        }
        public void Eventos()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void Invitados()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Invitado"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Invitados");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Invitados";
                connect.Close();
            }

        }
        public void Organizadores()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Organizador"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Organizadores");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Organizadores";
                connect.Close();
            }

        }
        public void Patrocinadores()
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Patrocinador"), connect);
                dat = new DataSet();
                ada.Fill(dat, "Patrocinadores");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Patrocinadores";
                connect.Close();
            }

        }
        public void ComentEvento(string eve)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("Select * from Evento, Comentario, Publicacion where Comentario.idPublicacion = Publicacion.idPublicacion and Publicacion.idEvento = Evento.idEvento and Evento.idEvento = {0} ", eve, connect);
                dat = new DataSet();
                ada.Fill(dat, "Comentarios");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Comentarios";
                connect.Close();
            }

        }
        public void EventPatro(string pat)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Evento, PatrocinadorEvento, Patrocinador where Patrocinador.idPatrocinador = {0} and Patrocinador.idPatrocinador = PatrocinadorEvento.idPatrocinador and PatrocinadorEvento.idEvento = Evento.idEvento", pat, connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
        public void InvEvent(string eve)
        {
            //Calificaciones del evento


            {
                connect.Open();
                ada = new SqlDataAdapter(string.Format("select * from Invitado, Evento, InvitadoEvento where Evento.idEvento = {0} and InvitadoEvento.idEvento = Evento.idEvento and InvitadoEvento.idInvitado = Invitado.idInvitado"), eve, connect);
                dat = new DataSet();
                ada.Fill(dat, "Eventos");
                //f2.dataGridinv.DataSource = dat;
                //f2.dataGridinv.DataMember = "Eventos";
                connect.Close();
            }

        }
    }
}
