using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.AutoMappers
{
    public static class CategoriaMapper
    {
        public static Categoria CategoriaViewModelToCategoria(CategoriaViewModel categoriaViewModel)
        {
            Categoria categoria = null;

            if (categoriaViewModel != null)
            {
                categoria = new Categoria();

                categoria.CategoriaId = categoriaViewModel.Id;
                categoria.Descricao = categoriaViewModel.Descricao;
                categoria.Nome = categoriaViewModel.Nome;
                categoria.Slug = categoriaViewModel.Slug;
            }

            return categoria;
        }

        public static CategoriaViewModel CategoriaToCategoriaViewModel(Categoria categoria)
        {

            CategoriaViewModel categoriaViewModel = null;

            if (categoria != null)
            {
                categoriaViewModel = new CategoriaViewModel();

                categoriaViewModel.Id = categoria.CategoriaId;
                categoriaViewModel.Descricao = categoria.Descricao;
                categoriaViewModel.Nome = categoria.Nome;
                categoriaViewModel.Slug = categoria.Slug;
            }

            return categoriaViewModel;
        }

        public static IEnumerable<CategoriaViewModel> ListaCategoriaToListaCategoriaViewModel(IEnumerable<Categoria> listaCategoria)
        {

            IList<CategoriaViewModel> listaCategoriaViewModel = null;

            if (listaCategoria != null)
            {
                CategoriaViewModel categoriaViewModel = null;
                listaCategoriaViewModel = new List<CategoriaViewModel>();

                foreach (var categoria in listaCategoria)
                {
                    categoriaViewModel = new CategoriaViewModel();

                    categoriaViewModel.Id = categoria.CategoriaId;
                    categoriaViewModel.Descricao = categoria.Descricao;
                    categoriaViewModel.Nome = categoria.Nome;
                    categoriaViewModel.Slug = categoria.Slug;

                    listaCategoriaViewModel.Add(categoriaViewModel);
                }
            }

            return listaCategoriaViewModel;
        }

        public static IEnumerable<Categoria> ListaCategoriaViewModelToListaCategoria(IEnumerable<CategoriaViewModel> listaCategoriaViewModel)
        {

            IList<Categoria> listaCategoria = null;

            if (listaCategoriaViewModel != null)
            {
                Categoria categoria = null;
                listaCategoria = new List<Categoria>();

                foreach (var categoriaViewModel in listaCategoriaViewModel)
                {
                    categoria = new Categoria();

                    categoria.CategoriaId = categoriaViewModel.Id;
                    categoria.Descricao = categoriaViewModel.Descricao;
                    categoria.Nome = categoriaViewModel.Nome;
                    categoria.Slug = categoriaViewModel.Slug;

                    listaCategoria.Add(categoria);
                }
            }

            return listaCategoria;
        }
    }
}
