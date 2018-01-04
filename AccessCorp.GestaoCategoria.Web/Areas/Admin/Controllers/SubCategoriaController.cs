using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class SubCategoriaController : BaseController
    {
        // GET: Admin/SubCategoria
        public ActionResult Index()
        {
            return View();
        }
    }
}