using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccessCorp.GestaoCategoria.Model;
using AccessCorp.GestaoCategoria.Web.Areas.Admin.Controllers;
using System.Web.Mvc;

namespace AccessCorp.GestaoCategoria.TDD.Controllers
{
    [TestClass]
    public class CategoriaControllerTest
    {
        [TestMethod]
        public void Cadastrar_Categoria()
        {
            CategoriaViewModel categoria = new CategoriaViewModel();

            categoria.Nome = "Veiculos";
            categoria.Slug = "veiculos";
            categoria.Descricao = "Veiculos automotivos";

            CategoriaController categoriaController = new CategoriaController();

           // ViewResult result = (ViewResult)categoriaController.Cadastrar(categoria);

            //Assert.AreEqual("TRUE", result.Model.ToString());
        }
    }
}
