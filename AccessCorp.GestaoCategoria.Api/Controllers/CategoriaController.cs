﻿using AccessCorp.GestaoCategoria.Api.Controllers.Base;
using AccessCorp.GestaoCategoria.CrossCutting.Helps;
using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace AccessCorp.GestaoCategoria.Api.Controllers
{
   // [Route("api/v1/categoria/")]
    public class CategoriaController : BaseController
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [Route("api/v1/categoria/cadastrar")]
        [HttpPost]
        public async Task<bool> Cadastrar(Categoria categoria)
        {
            bool ehCadastrado = false;

            //Categoria categoria = HelpObjectJSon<Categoria>.Deserialize(dataJson);

            ehCadastrado = _categoriaService.Cadastrar(categoria);

            return await Task.Run(() => ehCadastrado);
        }        
    }
}
