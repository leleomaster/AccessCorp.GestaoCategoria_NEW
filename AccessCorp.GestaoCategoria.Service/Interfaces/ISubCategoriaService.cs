using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Interfaces
{
    public interface ISubCategoriaService
    {
        IEnumerable<SubCategoriaViewModel> GetAll();
        bool Cadastrar(SubCategoriaViewModel subCategoriaViewModel);
    }
}
