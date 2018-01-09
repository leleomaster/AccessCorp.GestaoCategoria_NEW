using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = null;
        private readonly ChamadaApi<List<SubCategoriaViewModel>> _chamadaApiSubCategoria = null;

        public FormularioController()
        {
            _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();
            _chamadaApiSubCategoria = new ChamadaApi<List<SubCategoriaViewModel>>();
        }

        public async Task<ActionResult> Index()
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                model.ListaCategoriaViewModel =  await _chamadaApiCategoria.Get("", WebApiGestaoCategoria.ListaCategoria);
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Categoria(int id)
        {
            return RedirectToAction("SubCategoria", new { id = id });
        }

        [HttpGet]
        public async Task<ActionResult> SubCategoria(int id)
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                model.ListaSubCategoriaViewModel = await _chamadaApiSubCategoria.Get("", WebApiGestaoCategoria.ListaSubCategoriaFormulario);

                model.ListaSubCategoriaViewModel = model.ListaSubCategoriaViewModel.Where(s => s.IdCategoria == id).ToList();
            }
            catch (Exception ex)
            {

            }
            return View(model.ListaSubCategoriaViewModel);
        }


    }
}