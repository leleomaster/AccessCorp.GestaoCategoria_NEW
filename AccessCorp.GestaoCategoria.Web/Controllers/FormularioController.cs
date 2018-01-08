using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = null;

        public FormularioController()
        {
            _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Categoria()
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                model.ListaCategoriaViewModel = _chamadaApiCategoria.Get("", WebApiGestaoCategoria.ListaCategoria).Result;                
            }
            catch (Exception ex)
            {

                
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Categoria(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SubCategoria()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubCategoria(int id)
        {
            return View();
        }
    }
}