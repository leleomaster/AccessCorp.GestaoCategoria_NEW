using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    /// <summary>
    ///     Gerador de Formulários
    /// </summary>
    public class FormularioController : BaseController
    {
       
        public ActionResult Index()
        {
            return View();
        }
    }
}