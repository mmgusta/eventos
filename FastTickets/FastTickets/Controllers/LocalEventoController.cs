using FastTickets.Context;
using FastTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastTickets.DAL;

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

            LocalEventoDAL DAL = new LocalEventoDAL();
            var sucesso = DAL.Inserir(local);
            if (sucesso)
            {
                TempData["msg"] = "<script>alert('Local Cadastrado com sucesso');</script>";

                ModelState.Clear();
            }
            else
            {
                TempData["msg"] = "<script>alert('Este local já foi cadastrado');</script>";

            }


            ModelState.Clear();
            return View();
        }



    }
}
