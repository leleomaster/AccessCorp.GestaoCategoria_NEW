using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain.Business
{
    public class CategoriaBusiness
    {
        public bool EhValido { get; set; }

        public CategoriaBusiness()
        {
            EhValido = true;
        }

        public void Validar(Categoria categoria)
        {
            IsNullOrEmptyOrWhiteSpace(categoria.Nome);
            IsNullOrEmptyOrWhiteSpace(categoria.Slug);
            IsNullOrEmptyOrWhiteSpace(categoria.Descricao);

            TamanhoMaiorDois(categoria.Nome);
            TamanhoMaiorDois(categoria.Slug);
            TamanhoMaiorDois(categoria.Descricao);            
        }

        private void IsNullOrEmptyOrWhiteSpace(string campo)
        {
            EhValido = !string.IsNullOrEmpty(campo) || !string.IsNullOrWhiteSpace(campo);
        }

        private void TamanhoMaiorDois(string campo)
        {
            EhValido = (campo != null && campo.Length > 2);
        }
    }
}
