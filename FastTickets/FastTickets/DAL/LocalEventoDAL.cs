using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FastTickets.Context;
using FastTickets.Models;

namespace FastTickets.DAL
{
    public class LocalEventoDAL
    {


        public Boolean Inserir(LocalEventoModel local)
        {
            using (EFContexto contexto = new EFContexto())
            {

                if (!contexto.LocalEvento.Any(l => (l.Nome == local.Nome) && (l.Endereco == local.Endereco)))
                {
                    contexto.LocalEvento.Add(local);
                    contexto.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}