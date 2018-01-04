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
            var lista = from l in TesteLista()
                        select new
                        {
                            Id = l.Id,
                            Nome = l.Nome
                        };

            return Json(lista);
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