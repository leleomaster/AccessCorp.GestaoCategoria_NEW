using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Interfaces
{
    public interface ICategoriaService
    {
        bool Cadastrar(CategoriaViewModel categoria);
        bool Excluir(int ida);
        IEnumerable<CategoriaViewModel> GetAll();
    }
}
