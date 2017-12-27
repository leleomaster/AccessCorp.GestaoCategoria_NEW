using AccessCorp.GestaoCategoria.Api.Controllers.Base;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccessCorp.GestaoCategoria.Api.Controllers
{
    public class SubCategoriaController : BaseController
    {
        private readonly ISubCategoriaService _subCategoriaService;

        public SubCategoriaController(ISubCategoriaService subCategoriaService)
        {
            _subCategoriaService = subCategoriaService;
        }
    }
}
