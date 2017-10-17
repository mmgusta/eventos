using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastTickets.Models;
using FastTickets.Context;
using FastTickets.DAL;

namespace FastTickets.Controllers
{
    public class EventoController : Controller
    {
        //
        // GET: /Evento/

        private EFContexto context = new EFContexto();

        public ActionResult Index()
        {

            ViewBag.LocalId = new SelectList(context.LocalEvento.ToList(), "LocalId", "Nome");

            return View();
        }




        [HttpPost]
        public ActionResult Index(CadastroEventoModel evento)
        {
            EventoDAL DAL = new EventoDAL();
            var sucesso = DAL.Inserir(evento);
            if (sucesso)
            {
                TempData["msg"] = "<script>alert('Evento Cadastrado com sucesso');</script>";
                
                ModelState.Clear();
            }
            else
            {
                TempData["msg"] = "<script>alert('Este evento já existe');</script>";
                
            }
            ViewBag.LocalId = new SelectList(context.LocalEvento.ToList(), "LocalId", "Nome");

            return View();
        }

    }
}
