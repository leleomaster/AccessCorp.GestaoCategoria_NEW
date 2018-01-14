using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        void Cadastrar(Categoria categoria);
        void Excluir(Categoria categoria);
        IEnumerable<Categoria> GetAll();
        Categoria GetById(int id);
    }
}
