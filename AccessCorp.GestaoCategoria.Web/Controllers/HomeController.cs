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
    public class HomeController : Controller
    {
        private readonly ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = null;

        public HomeController()
        {
            _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();
        }

        public async Task<ActionResult> Index()
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                model.ListaCategoriaViewModel = await _chamadaApiCategoria.Get("", WebApiGestaoCategoria.ListaCategoria);
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }
    }
}