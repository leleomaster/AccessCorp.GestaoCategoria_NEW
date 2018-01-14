using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.CrossCutting.AutoMappers;
using System.Transactions;
using System.Data.Entity.Validation;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class SubCategoriaService : ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ITextoCampoRepository _textoCampoRepository;
        private readonly ICampoRepository _campoRepository;
        private readonly ITipoCampoRepository _tipoCampoRepository;

        public SubCategoriaService(ISubCategoriaRepository subCategoriaRepository, ITextoCampoRepository textoCampoRepository, ICampoRepository campoRepository,
            ITipoCampoRepository tipoCampoRepository, ICategoriaRepository categoriaRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
            _textoCampoRepository = textoCampoRepository;
            _campoRepository = campoRepository;
            _tipoCampoRepository = tipoCampoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IEnumerable<SubCategoriaViewModel> GetAll()
        {
            IList<SubCategoriaViewModel> lista = null;
            try
            {
                var litsaSubCategoria = _subCategoriaRepository.GetAll();

                lista = SubCategoriaMapper.ListaCategoriaToListaCategoriaViewModel(litsaSubCategoria).ToList();
            }
            catch (Exception ex)
            {
                // log(ex.Message);
            }
            return lista;
        }

        public bool Cadastrar(SubCategoriaViewModel subCategoriaViewModel)
        {
            bool ehCadastrado = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    var subCategoria = SubCategoriaMapper.CategoriaViewModelToCategoria(subCategoriaViewModel);

                    _tipoCampoRepository.GetById(Convert.ToInt32(subCategoriaViewModel.CamposViewModel[1].IdTipoCampo));

                    subCategoria.Categoria = _categoriaRepository.GetById(subCategoriaViewModel.IdCategoria);

                    if (subCategoria.Campos != null && subCategoria.Campos.Count > 0)
                    {
                        foreach (var campo in subCategoria.Campos)
                        {
                            campo.TipoCampo = _tipoCampoRepository.GetById(campo.TipoCampo.TipoCampoId);
                        }
                    }

                    _subCategoriaRepository.Cadastrar(subCategoria);

                    ehCadastrado = true;

                    scope.Complete();
                }
            }
            catch (Exception eve)
            {
                // log(ex.Message);
            }

            return ehCadastrado;
        }
    }
}
