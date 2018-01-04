using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class CategoriaController : BaseController
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CategoriaViewModel categoria)
        {
            return View();
        }
    }
}