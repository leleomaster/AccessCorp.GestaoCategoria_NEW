using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class SubCategoriaController : BaseController
    {
        private ChamadaApi<SubCategoriaViewModel> _chamadaApiSubCategoria;
        private ChamadaApi<object> _chamadaApiSubCategoria2;
        private ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria;
        private ChamadaApi<List<TipoCampoViewModel>> _chamadaApiTipoCampoViewModel;

        public SubCategoriaController()
        {
            _chamadaApiSubCategoria = new ChamadaApi<SubCategoriaViewModel>();
            _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();
            _chamadaApiTipoCampoViewModel = new ChamadaApi<List<TipoCampoViewModel>>();
            _chamadaApiSubCategoria2 = new ChamadaApi<object>();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<PartialViewResult> Cadastrar(SubCategoriaViewModel subCategoria)
        {
            string dataJSon = HelpObjectJSon<SubCategoriaViewModel>.Serialize(subCategoria);

            var result = await _chamadaApiSubCategoria2.Post(dataJSon, WebApiGestaoCategoria.AdminCadastrarSubCategoria);
            
            ViewBag.ExibirMensagem = Mensagem.Exibir(result.ToString());

            return PartialView("_Mensagem");
        }

        [HttpGet]
        public async Task<JsonResult> ListaCategoria()
        {
            var resposta = await _chamadaApiCategoria.Get(WebApiGestaoCategoria.ListaCategoria);

            var lista = (from l in resposta
                         select new
                         {
                             Id = l.Id,
                             Nome = l.Nome
                         }).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<JsonResult> ListaTipoCampo()
        {
            var resposta = await _chamadaApiTipoCampoViewModel.Get(WebApiGestaoCategoria.ListaTipoCampo);

            var lista = (from l in resposta
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
    }
}