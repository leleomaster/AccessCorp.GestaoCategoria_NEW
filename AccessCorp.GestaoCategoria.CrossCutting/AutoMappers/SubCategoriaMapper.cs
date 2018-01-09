using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.AutoMappers
{
    public class SubCategoriaMapper
    {
        public static IEnumerable<SubCategoriaViewModel> ListaCategoriaToListaCategoriaViewModel(IEnumerable<SubCategoria> listaSubCategoria)
        {

            IList<SubCategoriaViewModel> listaSubCategoriaViewModel = null;

            if (listaSubCategoria != null)
            {
                SubCategoriaViewModel subCategoriaViewModel = null;
                listaSubCategoriaViewModel = new List<SubCategoriaViewModel>();

                foreach (var subCategoria in listaSubCategoria)
                {
                    subCategoriaViewModel = new SubCategoriaViewModel();

                    subCategoriaViewModel.SubCategoriaId = subCategoria.SubCategoriaId;
                    subCategoriaViewModel.Descricao = subCategoria.Descricao;
                    subCategoriaViewModel.Nome = subCategoria.Nome;
                    subCategoriaViewModel.Slug = subCategoria.Slug;

                    subCategoriaViewModel.IdCategoria = subCategoria.Categoria.CategoriaId;

                    if (subCategoria.Campos != null && subCategoria.Campos.Count > 0)
                    {
                        subCategoriaViewModel.CamposViewModel = new List<CampoViewModel>();

                        foreach (var campo in subCategoria.Campos)
                        {
                            CampoViewModel campoViewModel = new CampoViewModel();

                            campoViewModel.CampoId = campo.CampoId;
                            campoViewModel.Obrigatorio = campo.Obrigatorio;
                            campoViewModel.Ordem = campo.Ordem;

                            if (campoViewModel.TextoCampos != null && campoViewModel.TextoCampos.Count > 0)
                            {
                                campoViewModel.TextoCampos = new List<TextoCampoViewModel>();

                                foreach (var textoCampo in campoViewModel.TextoCampos)
                                {
                                    TextoCampoViewModel textoCampoViewModel = new TextoCampoViewModel();

                                    textoCampoViewModel.TextoCampoId = textoCampo.TextoCampoId;
                                    textoCampoViewModel.Texto = textoCampo.Texto;
                                    textoCampoViewModel.Valor = textoCampo.Valor;

                                    campoViewModel.TextoCampos.Add(textoCampoViewModel);
                                }
                            }
                            subCategoriaViewModel.CamposViewModel.Add(campoViewModel);
                        }
                    }
                    listaSubCategoriaViewModel.Add(subCategoriaViewModel);
                }
            }
            return listaSubCategoriaViewModel;
        }

        public static SubCategoria CategoriaViewModelToCategoria(SubCategoriaViewModel subCategoriaViewModel)
        {
            SubCategoria subCategoria = null;

            if (subCategoriaViewModel != null)
            {
                subCategoria = new SubCategoria();

                subCategoria.SubCategoriaId = subCategoriaViewModel.SubCategoriaId;
                subCategoria.Descricao = subCategoriaViewModel.Descricao;
                subCategoria.Nome = subCategoriaViewModel.Nome;
                subCategoria.Slug = subCategoriaViewModel.Slug;

                subCategoria.Categoria = new Categoria { CategoriaId = subCategoriaViewModel.IdCategoria };

                if (subCategoria.Campos != null && subCategoria.Campos.Count > 0)
                {
                    subCategoriaViewModel.CamposViewModel = new List<CampoViewModel>();

                    foreach (var campo in subCategoria.Campos)
                    {
                        CampoViewModel campoViewModel = new CampoViewModel();

                        campoViewModel.CampoId = campo.CampoId;
                        campoViewModel.Obrigatorio = campo.Obrigatorio;
                        campoViewModel.Ordem = campo.Ordem;

                        if (campoViewModel.TextoCampos != null && campoViewModel.TextoCampos.Count > 0)
                        {
                            campoViewModel.TextoCampos = new List<TextoCampoViewModel>();

                            foreach (var textoCampo in campoViewModel.TextoCampos)
                            {
                                TextoCampoViewModel textoCampoViewModel = new TextoCampoViewModel();

                                textoCampoViewModel.TextoCampoId = textoCampo.TextoCampoId;
                                textoCampoViewModel.Texto = textoCampo.Texto;
                                textoCampoViewModel.Valor = textoCampo.Valor;

                                campoViewModel.TextoCampos.Add(textoCampoViewModel);
                            }
                        }
                        subCategoriaViewModel.CamposViewModel.Add(campoViewModel);
                    }
                }                
            }

            return subCategoria;
        }

        public static SubCategoriaViewModel CategoriaToCategoriaViewModel(SubCategoria subCategoria)
        {

            SubCategoriaViewModel subCategoriaViewModel = null;

            if (subCategoria != null)
            {
                subCategoriaViewModel = new SubCategoriaViewModel();

                subCategoriaViewModel.SubCategoriaId = subCategoria.SubCategoriaId;
                subCategoriaViewModel.Descricao = subCategoria.Descricao;
                subCategoriaViewModel.Nome = subCategoria.Nome;
                subCategoriaViewModel.Slug = subCategoria.Slug;

                subCategoriaViewModel.IdCategoria = subCategoria.Categoria.CategoriaId;
            }

            return subCategoriaViewModel;
        }

    }
}
