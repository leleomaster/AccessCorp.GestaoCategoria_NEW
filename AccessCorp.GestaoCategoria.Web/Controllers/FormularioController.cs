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
        public ActionResult Categoria(int? id)
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                if (id == null)
                {
                    model.ListaCategoriaViewModel = _chamadaApiCategoria.Get("", WebApiGestaoCategoria.ListaCategoria).Result;
                }
                else
                {
                    model.ListaCategoriaViewModel = _chamadaApiCategoria.Get("", WebApiGestaoCategoria.ListaCategoria).Result.Where(c=>c.Id == id).ToList();
                }
            }
            catch (Exception ex)
            {


            }
            return View(model);
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