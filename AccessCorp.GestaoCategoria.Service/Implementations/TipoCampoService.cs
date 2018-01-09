using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.CrossCutting.AutoMappers;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class TipoCampoService : ITipoCampoService
    {
        private readonly ITipoCampoRepository _tipoCampoRepository;

        public TipoCampoService(ITipoCampoRepository tipoCampoRepository)
        {
            _tipoCampoRepository = tipoCampoRepository;
        }

        public IEnumerable<TipoCampoViewModel> Get()
        {
            try
            {
                var resultado = _tipoCampoRepository.GetAll();

                IEnumerable<TipoCampoViewModel> lista = TipoCampoMapper.TipoCampoToTipoCampoViewModel(resultado);

                return lista;
            }
            catch (Exception ex)
            {
                //log.Error
                return null;
            }
        }
    }
}
