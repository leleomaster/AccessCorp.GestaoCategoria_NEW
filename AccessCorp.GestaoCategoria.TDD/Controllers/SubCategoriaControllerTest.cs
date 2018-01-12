using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace AccessCorp.GestaoCategoria.TDD.Controllers
{
    [TestClass]
    public class SubCategoriaControllerTest
    {
        [TestMethod]
        public void Cadastrar_sub_Categoria()
        {
            SubCategoriaViewModel subCategoria = new SubCategoriaViewModel();

            subCategoria.Slug = "veiculos-som";
            subCategoria.Descricao = "Som de veiculos";

            for (int i = 0; i < 2; i++)
            {
                CampoViewModel campo = new CampoViewModel();

                campo.Descricao = "Descricao " + i;
                campo.Obrigatorio = true;
                campo.Ordem = (short)i;
                campo.TipoCampoViewModel = new TipoCampoViewModel() { TipoCampoId = i };

                for (int j = 0; j < 2; j++)
                {
                    TextoCampoViewModel textoCampo = new TextoCampoViewModel();

                    textoCampo.Texto = "Texto " + i;
                    textoCampo.Valor = "Valor " + i;

                    campo.TextoCampos = new List<TextoCampoViewModel>();

                    campo.TextoCampos.Add(textoCampo);
                }
                subCategoria.CamposViewModel.Add(campo);
            }

            SubCategoriaController subCategoriaController = new SubCategoriaController();

            //ViewResult result = (ViewResult)subCategoriaController.Cadastrar(subCategoria);

            //Assert.AreEqual("TRUE", result.Model.ToString());
        }
    }
}
