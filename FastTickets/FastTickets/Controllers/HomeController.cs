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

        public ActionResult Editar(int id)
        {
            CadastroEventoModel evento = new EventoDAL().ConsultarId(id);
            return View(evento);
        }

        [HttpPost]
        public ActionResult Editar(CadastroEventoModel evento)
        {
            context.SaveChanges();
            return View();
        }


        [HttpPost]
        public ActionResult Index(string nome)
        {
           IList<CadastroEventoModel> evento = new EventoDAL().ConsultarNome(nome);
            return View(evento);
        }

        public ActionResult Excluir(int id)
        {
            CadastroEventoModel evento = context.Evento.Find(id);
            return View(evento);
        }

        [HttpPost, ActionName("Excluir")]

        public ActionResult ExcluirConfirmar(int id)
        {
            CadastroEventoModel evento = context.Evento.Find(id);
            context.Evento.Remove(evento);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
