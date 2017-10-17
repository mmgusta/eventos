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
            ViewBag.LocalId = new SelectList(context.LocalEvento.ToList(), "LocalId", "Nome");
            return View(evento);
        }

        [HttpPost]
        public ActionResult Editar(CadastroEventoModel evento)
        {
            ViewBag.LocalId = new SelectList(context.LocalEvento.ToList(), "LocalId", "Nome");
            EventoDAL DAL = new EventoDAL();
            DAL.Editar(evento);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Index(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                IList<CadastroEventoModel> evento = new EventoDAL().ConsultarNome(nome);

                return View(evento);

            }
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int id)
        {
            CadastroEventoModel evento = context.Evento.Find(id);
            return View(evento);
        }

        [HttpPost, ActionName("Excluir")]

        public ActionResult ExcluirConfirmar(int  id)
        {

            CadastroEventoModel evento = context.Evento.Find(id);
            context.Evento.Remove(evento);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
