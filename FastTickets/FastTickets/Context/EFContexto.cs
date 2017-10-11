using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FastTickets.Models;
namespace FastTickets.Context
{
    public class EFContexto : DbContext
    {
        public	EFContexto()	:	base("Servidor")	
        {

        }


        public DbSet<LocalEventoModel> LocalEvento { get; set; }
        public DbSet<CadastroEventoModel> Evento { get; set; }


    }
}