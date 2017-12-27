using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Web.Comunicacao;
using AccessCorp.GestaoCategoria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CallApi<CategoriaViewModel> callApiCategoria;
        private readonly string endPoint;

        public CategoriaController()
        {
            callApiCategoria = new CallApi<CategoriaViewModel>();
            endPoint = "api/v1/categoria/cadastrar";
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(CategoriaViewModel categoria)
        {
            var result = await callApiCategoria.Post(HelpObjectJSon<CategoriaViewModel>.Serialize(categoria), endPoint);

            return View();
        }

        [HttpGet]
        public ActionResult Atualizar()
        {

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Atualizar(CategoriaViewModel categoria)
        {
            var result = await callApiCategoria.Put(HelpObjectJSon<CategoriaViewModel>.Serialize(categoria), endPoint);

            return View();
        }
    }
}