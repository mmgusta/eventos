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

        public IList<CadastroEventoModel> ListarTodos()
        {
            return
                new EFContexto().Evento.ToList<CadastroEventoModel>();

        }

    }
}