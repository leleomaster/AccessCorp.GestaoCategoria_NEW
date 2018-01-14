using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace AccessCorp.GestaoCategoria.Web.Controllers
{
    [Route("Formulario")]
    public class FormularioController : Controller
    {
        private readonly ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = null;
        private readonly ChamadaApi<List<SubCategoriaViewModel>> _chamadaApiSubCategoria = null;

        public FormularioController()
        {
            _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();
            _chamadaApiSubCategoria = new ChamadaApi<List<SubCategoriaViewModel>>();
        }

        [HttpGet]
        public async Task<ActionResult> SubCategoria(int id)
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                var resultado = await _chamadaApiCategoria.Get(WebApiGestaoCategoria.ListaCategoria);

                model.CategoriaViewModel = resultado.FirstOrDefault(c => c.Id == id);

                model.ListaSubCategoriaViewModel = await _chamadaApiSubCategoria.Get(WebApiGestaoCategoria.ListaSubCategoriaFormulario);

                model.ListaSubCategoriaViewModel = model.ListaSubCategoriaViewModel.Where(s => s.IdCategoria == id).ToList();
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Formulario(int id)  //    idSubCategoria
        {
            FormularioViewModel model = new FormularioViewModel();
            try
            {
                var resultado = await _chamadaApiCategoria.Get(WebApiGestaoCategoria.ListaCategoria);

                model.ListaSubCategoriaViewModel = await _chamadaApiSubCategoria.Get(WebApiGestaoCategoria.ListaSubCategoriaFormulario);

                model.SubCategoriaViewModel = model.ListaSubCategoriaViewModel.FirstOrDefault(s => s.SubCategoriaId == id);

                if (model.SubCategoriaViewModel != null)
                {
                    model.CategoriaViewModel = resultado.FirstOrDefault(c => c.Id == model.SubCategoriaViewModel.IdCategoria);
                }
            }
            catch (Exception ex)
            {

            }
            return View(model);
        }
    }
}