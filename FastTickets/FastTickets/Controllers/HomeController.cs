using FastTickets.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastTickets.DAL;
using FastTickets.Models;

namespace FastTickets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private EFContexto context = new EFContexto();
        
        public ActionResult Index()
        {

            EventoDAL evento = new EventoDAL();
            IList<CadastroEventoModel> lista = evento.ListarTodos();


            return View(lista);
        }

    }
}
