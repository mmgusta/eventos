using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FastTickets.Context;
using FastTickets.Models;

namespace FastTickets.DAL
{
    public class EventoDAL
    {

        EFContexto context = new EFContexto();

        public IList<CadastroEventoModel> ListarTodos()
        {
            return
                new EFContexto().Evento.ToList<CadastroEventoModel>();

        }

        public IList<CadastroEventoModel> ConsultarNome(string nome)
        {

            return new EFContexto().Evento.Where<CadastroEventoModel>(e => e.Nome == nome).ToList();
        }

        public CadastroEventoModel ConsultarId(int id)
        {
            return new EFContexto().Evento.FirstOrDefault<CadastroEventoModel>(e => e.EventoId == id);
        }

        public void Editar(CadastroEventoModel evento)
        {
            using (EFContexto contexto = new EFContexto())
            {

                contexto.Entry(evento).State = EntityState.Modified;
                contexto.SaveChanges();

            }

        }
        public Boolean Inserir(CadastroEventoModel evento)
        {
            using (EFContexto contexto = new EFContexto())
            {

                if (!contexto.Evento.Any(o => (o.Nome == evento.Nome) && (o.LocalId == evento.LocalId) && (o.Data == evento.Data)))
                {
                    contexto.Evento.Add(evento);
                    contexto.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        //public void Excluir(CadastroEventoModel evento)
        //{

        //    using (EFContexto contexto = new EFContexto())
        //    {
        //        contexto.Entry(evento).State = EntityState.Deleted;
        //        contexto.SaveChanges();

        //    }


        //}

    }
}