using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.AutoMappers
{
    public static class TextCampoMapper
    {
        public static TextoCampo CamopViewModelToCampo(TextoCampoViewModel textCampoViewModel)
        {
            TextoCampo textoCampo = new TextoCampo();

            textoCampo.TextoCampoId = textCampoViewModel.TextoCampoId;
            textoCampo.Texto = textCampoViewModel.Texto;
            textoCampo.Valor = textCampoViewModel.Valor;

            return textoCampo;
        }
    }
}
