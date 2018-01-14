using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Domain.Business;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.CrossCutting.AutoMappers;
using System.Collections.Generic;

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

        public bool Cadastrar(CategoriaViewModel categoriaViewModel)
        {
            bool ehCadastrado = false;

            try
            {
                var categoria = CategoriaMapper.CategoriaViewModelToCategoria(categoriaViewModel);

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

        public IEnumerable<CategoriaViewModel> GetAll()
        {
            IEnumerable<CategoriaViewModel> listaCategoriaViewModel = null;

            try
            {
                var listaCategoria = _categoriaRepository.GetAll();

                listaCategoriaViewModel = CategoriaMapper.ListaCategoriaToListaCategoriaViewModel(listaCategoria);
            }
            catch (Exception ex)
            {
                // log(ex.Message);
            }

            return listaCategoriaViewModel;
        }

        public bool Excluir(int id)
        {
            bool ehExcluido = false;

            try
            {
                 var categoria =_categoriaRepository.GetById(id);

                 _categoriaRepository.Excluir(categoria);

                ehExcluido = true;
            }
            catch (Exception ex)
            {
                // log(ex.Message);
            }
            return ehExcluido;
        }
    }
}
