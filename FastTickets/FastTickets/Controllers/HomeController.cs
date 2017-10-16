using FastTickets.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastTickets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private EFContexto context = new EFContexto();


        public ActionResult Index()
        {

            ViewBag.EventoId = new SelectList(context.Evento.ToList(), "EventoId", "NomeEvento"); 

            return View();
        }

    }
}
