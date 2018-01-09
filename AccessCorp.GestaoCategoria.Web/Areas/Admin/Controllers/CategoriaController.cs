using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers.Base;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class CategoriaController : BaseController
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CategoriaViewModel categoria)
        {
            ChamadaApi<object> _chamadaApiCategoria = new ChamadaApi<object>();

            string dataJSon = HelpObjectJSon<CategoriaViewModel>.Serialize(categoria);

            var result = _chamadaApiCategoria.Post(dataJSon, WebApiGestaoCategoria.AdminCadastrarCategoria);

            return View(result.Result.ToString().ToUpper());
        }
               
        public JsonResult Lista()
        {
            ChamadaApi<List<CategoriaViewModel>> _chamadaApiCategoria = new ChamadaApi<List<CategoriaViewModel>>();

            var lista = _chamadaApiCategoria.Get(null, WebApiGestaoCategoria.ListaCategoria);

            return Json(lista);
        }
    }
}