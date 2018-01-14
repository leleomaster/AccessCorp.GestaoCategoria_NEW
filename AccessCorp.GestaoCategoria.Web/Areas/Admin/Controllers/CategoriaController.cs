using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Linq;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    [RoutePrefix("admin/categoria/")]
    public class CategoriaController : BaseController
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.ExibirMensagem = "";

            return View();
        }

        [Route("cadastrar")]
        [HttpPost]
        public async Task<PartialViewResult> Cadastrar(CategoriaViewModel categoria)
        {
            ChamadaApi<object> _chamadaApiCategoria = new ChamadaApi<object>();

            string dataJSon = HelpObjectJSon<CategoriaViewModel>.Serialize(categoria);

            var resposta = await _chamadaApiCategoria.Post(dataJSon, WebApiGestaoCategoria.AdminCadastrarCategoria);

            ViewBag.ExibirMensagem = Mensagem.Exibir(resposta.ToString());

            return PartialView("_Mensagem");
        }

        [Route("lista")]
        [HttpGet]
        public async Task<JsonResult> Lista()
        {
            ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();

            var resposta = await _chamadaApiCategoria.Get(WebApiGestaoCategoria.ListaCategoria);

            var lista = (from l in resposta
                         select new
                         {
                             Id = l.Id,
                             Nome = l.Nome,
                             Descricao = l.Descricao,
                             Slug = l.Slug
                         }).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
       
        [Route("exluir")]
        [HttpPost]
        public async Task<PartialViewResult> Excluir(CategoriaViewModel categoriaViewModel)
        {
            ChamadaApi<object> _chamadaApiCategoria = new ChamadaApi<object>();

            var resposta = await _chamadaApiCategoria.Delete(categoriaViewModel.Id.ToString(), WebApiGestaoCategoria.ExcluirCategoria);

            ViewBag.ExibirMensagem = Mensagem.Exibir(resposta.ToString());

            return PartialView("_Mensagem");
        }
        
    }
}