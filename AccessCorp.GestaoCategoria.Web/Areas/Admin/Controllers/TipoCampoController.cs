using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class TipoCampoController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(TipoCampoViewModel tipoCampo)
        {
            return View();
        }
    }
}