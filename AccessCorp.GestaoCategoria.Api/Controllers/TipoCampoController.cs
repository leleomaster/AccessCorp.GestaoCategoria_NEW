using AccessCorp.GestaoCategoria.Api.Controllers.Base;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace AccessCorp.GestaoCategoria.Api.Controllers
{
    public class TipoCampoController : BaseController
    {
        private readonly ITipoCampoService _tipoCampoService;

        public TipoCampoController(ITipoCampoService tipoCampoService)
        {
            _tipoCampoService = tipoCampoService;
        }

        [Route("api/v1/tipocampos/lista")]
        [HttpGet]
        public async Task<IHttpActionResult> Lista()
        {
            return Ok(await Task.Run(() => { return _tipoCampoService.Get(); }));
        }
    }
}
