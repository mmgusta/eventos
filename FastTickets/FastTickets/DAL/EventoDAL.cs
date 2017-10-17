using System;
using System.Collections.Generic;
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

        /*    public void Editar(CadastroEventoModel evento)
            {
                using (EFContexto contexto= new EFContexto())
                {
                    CadastroEventoModel cad = contexto.Evento.Single(e => e.EventoId == evento.EventoId);
                    cad = evento;
                    contexto.SaveChanges();

                }

            }*/


        public CadastroEventoModel Excluir(int id)
        {
            CadastroEventoModel evento = new EFContexto().Evento.Find(id);


            return context.Evento.Remove(evento);
        }

    }
}