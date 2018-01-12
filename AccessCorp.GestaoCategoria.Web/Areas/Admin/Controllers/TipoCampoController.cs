using AccessCorp.GestaoCategoria.CrossCutting.ComunicacaoApi;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.EndPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers
{
    public class TipoCampoController : Controller
    {
        private ChamadaApi<List<TipoCampoViewModel>> _chamadaApiTipoCampo;

        public TipoCampoController()
        {
            _chamadaApiTipoCampo = new ChamadaApi<List<TipoCampoViewModel>>();
        }

        public async Task<JsonResult> Lista()
        {

            var lista = await _chamadaApiTipoCampo.Get(null, WebApiGestaoCategoria.ListaTipoCampo);

            return Json(lista);
        }
    }
}