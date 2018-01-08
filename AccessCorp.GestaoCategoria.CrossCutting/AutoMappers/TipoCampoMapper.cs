using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.AutoMappers
{
    public static class TipoCampoMapper
    {
        public static IEnumerable<TipoCampoViewModel> TipoCampoToTipoCampoViewModel(IEnumerable<TipoCampo> tipoCampos)
        {
            List<TipoCampoViewModel> lista = null;
            if (tipoCampos.Any())
            {
                lista = new List<TipoCampoViewModel>();
                TipoCampoViewModel tipoCampoViewModel = null;

                foreach (var tipoCampo in tipoCampos)
                {
                    tipoCampoViewModel = new TipoCampoViewModel();

                    tipoCampoViewModel.Nome = tipoCampo.Nome;
                    tipoCampoViewModel.TipoCampoId = tipoCampo.TipoCampoId;

                    lista.Add(tipoCampoViewModel);
                }
            }
            return lista;
        }
    }
}
