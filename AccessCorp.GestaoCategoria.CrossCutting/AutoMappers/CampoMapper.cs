using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.AutoMappers
{
    public static class CampoMapper
    {
        public static Campo CampoViewModelToCampo(CampoViewModel campoViewModel)
        {
            Campo campo = new Campo();

            campo.CampoId = campoViewModel.CampoId;
            campo.Obrigatorio = campoViewModel.Obrigatorio;
            campo.Ordem = campoViewModel.Ordem;
            campo.Descricao = campoViewModel.Descricao;

            if (campo.SubCategoria != null)
            {
                campo.SubCategoria = new SubCategoria()
                {
                    SubCategoriaId = campo.SubCategoria.SubCategoriaId
                };
            }

            if (campo.TipoCampo != null)
            {
                campo.TipoCampo = new TipoCampo()
                {
                    TipoCampoId = campo.TipoCampo.TipoCampoId
                };
            }

            return campo;
        }
    }
}
