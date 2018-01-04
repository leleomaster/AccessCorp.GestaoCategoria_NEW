using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Controllers
{
    public class ContaUsuarioController : Controller
    {
        // GET: ContaUsuario
        public ActionResult Login()
        {
            return View();
        }
    }
}