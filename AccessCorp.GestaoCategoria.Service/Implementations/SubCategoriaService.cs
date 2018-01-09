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

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class SubCategoriaService : ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;
        private readonly ITextoCampoRepository _textoCampoRepository;
        private readonly ICampoRepository _campoRepository;

        public SubCategoriaService(ISubCategoriaRepository subCategoriaRepository, ITextoCampoRepository textoCampoRepository, ICampoRepository campoRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
            _textoCampoRepository = textoCampoRepository;
            _campoRepository = campoRepository;
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

                    _subCategoriaRepository.Cadastrar(subCategoria);

                    if (subCategoria.Campos != null && subCategoria.Campos.Count > 0)
                    {
                        foreach (var campo in subCategoria.Campos)
                        {
                            _campoRepository.Cadastrar(campo);

                            if(campo.TextoCampos != null && campo.TextoCampos.Count > 0)
                            {
                                foreach (var textoCampo in campo.TextoCampos)
                                {
                                    _textoCampoRepository.Cadastrar(textoCampo);
                                }
                            }
                        }
                    }

                    ehCadastrado = true;

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                // log(ex.Message);
            }

            return ehCadastrado;
        }
    }
}
