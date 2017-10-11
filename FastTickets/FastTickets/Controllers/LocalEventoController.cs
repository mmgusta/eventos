using FastTickets.Context;
using FastTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastTickets.Controllers
{
    public class LocalEventoController : Controller
    {
        //
        // GET: /LocalEvento/

        private EFContexto context = new EFContexto();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LocalEventoModel local)
        {

            context.LocalEvento.Add(local);
            context.SaveChanges();

            return View();
        }



    }
}
