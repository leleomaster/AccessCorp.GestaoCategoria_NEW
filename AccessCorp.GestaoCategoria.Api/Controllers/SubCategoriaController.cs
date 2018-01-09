﻿using AccessCorp.GestaoCategoria.Api.Controllers.Base;
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

namespace AccessCorp.GestaoCategoria.Api.Controllers
{
    public class SubCategoriaController : BaseController
    {
        private readonly ISubCategoriaService _subCategoriaService;

        public SubCategoriaController(ISubCategoriaService subCategoriaService)
        {
            _subCategoriaService = subCategoriaService;
        }

        [Route("api/v1/subcategoria/lista")]
        [HttpGet]
        public async Task<IHttpActionResult> Lista()
        {

          var lista =_subCategoriaService.GetAll();

            return Ok(await Task.Run(() => { return lista; }));
        }

        [Route("api/v1/subcategoria/cadastrar")]
        [HttpPost]
        public async Task<bool> Cadastrar(SubCategoriaViewModel categoria)
        {
            bool ehCadastrado = false;

            //Categoria categoria = HelpObjectJSon<Categoria>.Deserialize(dataJson);

            ehCadastrado = _subCategoriaService.Cadastrar(categoria);

            return await Task.Run(() => ehCadastrado);
        }
    }
}
