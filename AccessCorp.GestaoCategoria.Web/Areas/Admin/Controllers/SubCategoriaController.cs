using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class SubCategoriaController : BaseController
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(SubCategoriaViewModel subCategoria)
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListaCategoria()
        {
            var lista = (from l in TesteLista()
                         select new
                         {
                             Id = l.Id,
                             Nome = l.Nome
                         }).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ListaTipoCampo()
        {
            var lista = (from l in TesteListaTipoCampo()
                         select new
                         {
                             Id = l.TipoCampoId,
                             Nome = l.Nome
                         }).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public PartialViewResult CamposAdicionais()
        {
            return PartialView("_CamposAdicionais");
        }
        private List<TipoCampoViewModel> TesteListaTipoCampo()
        {
            return new List<TipoCampoViewModel>()
            {
                new TipoCampoViewModel()
                {
                    TipoCampoId = 1,
                    Nome = "radio"
                },
                new TipoCampoViewModel()
                {
                    TipoCampoId = 2,
                    Nome = "check"
                },
                new TipoCampoViewModel()
                {
                    TipoCampoId = 3,
                    Nome = "button"
                },
                new TipoCampoViewModel()
                {
                    TipoCampoId = 4,
                    Nome = "text"
                },
                new TipoCampoViewModel()
                {
                    TipoCampoId = 5,
                    Nome = "textarea"
                },
                new TipoCampoViewModel()
                {
                    TipoCampoId = 6,
                    Nome = "select"
                },
            };
        }

        private List<CategoriaViewModel> TesteLista()
        {
            return new List<CategoriaViewModel>()
            {
                new CategoriaViewModel()
                {
                    Id = 1,
                    Nome="Automovel"
                },
                new CategoriaViewModel()
                {
                    Id = 2,
                    Nome="Comercio"
                },
                new CategoriaViewModel()
                {
                    Id = 3,
                    Nome="Banco"
                }
            };

        }

    }
}