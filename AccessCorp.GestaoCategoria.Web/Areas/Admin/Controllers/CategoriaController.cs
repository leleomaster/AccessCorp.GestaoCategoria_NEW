using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class CategoriaController : BaseController
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.ExibirMensagem = "";

            return View();
        }

        [HttpPost]
        public async Task<PartialViewResult> Cadastrar(CategoriaViewModel categoria)
        {
            ChamadaApi<object> _chamadaApiCategoria = new ChamadaApi<object>();

            string dataJSon = HelpObjectJSon<CategoriaViewModel>.Serialize(categoria);

            var resposta = await _chamadaApiCategoria.Post(dataJSon, WebApiGestaoCategoria.AdminCadastrarCategoria);

            ViewBag.ExibirMensagem = Mensagem.Exibir(resposta.ToString());

            return PartialView("_Mensagem");
        }

        public async Task<JsonResult> Lista()
        {
            ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();

            var lista = await _chamadaApiCategoria.Get(null, WebApiGestaoCategoria.ListaCategoria);

            return Json(lista);
        }
    }
}