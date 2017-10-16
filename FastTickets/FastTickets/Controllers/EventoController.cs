using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastTickets.Models;
using FastTickets.Context;

namespace FastTickets.Controllers
{
    public class EventoController : Controller
    {
        //
        // GET: /Evento/

        private EFContexto context = new EFContexto();

        public ActionResult Index()
        {
           
            ViewBag.Locais = new SelectList(context.LocalEvento.ToList(), "LocalId", "Nome");            

            return View();
        }

        [HttpPost]
        public ActionResult Index(CadastroEventoModel evento)
        {

            context.Evento.Add(evento);
            context.SaveChanges();

            return View();
        }

    }
}
