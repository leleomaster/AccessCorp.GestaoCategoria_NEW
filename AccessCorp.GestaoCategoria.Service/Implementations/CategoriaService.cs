using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Domain.Business;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly CategoriaBusiness _categoriaBusiness;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
            _categoriaBusiness = new CategoriaBusiness();
        }

        public bool Cadastrar(Categoria categoria)
        {
            bool ehCadastrado = false;

            try
            {
                _categoriaBusiness.Validar(categoria);

                if (_categoriaBusiness.EhValido)
                {
                    _categoriaRepository.Cadastrar(categoria);
                }

                ehCadastrado = true;
            }
            catch (Exception ex)
            {
                // log(ex.Message);
            }

            return ehCadastrado;
        }
    }
}
