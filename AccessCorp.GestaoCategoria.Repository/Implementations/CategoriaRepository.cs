using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Factories;
using AccessCorp.GestaoCategoria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using AccessCorp.GestaoCategoria.Domain.Models;

namespace AccessCorp.GestaoCategoria.Repository.Implementations
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DbContextAccessCorp _dbContextAccessCorp;

        public CategoriaRepository()
        {
            _dbContextAccessCorp = FactoryDbContextAccessCorp.CreateDbContextAccessCorp();
        }

        public void Cadastrar(Categoria categoria)
        {
            _dbContextAccessCorp.Categorias.Add(categoria);

            _dbContextAccessCorp.SaveChanges();
        }

        public void Excluir(Categoria categoria)
        {
            _dbContextAccessCorp.Categorias.Remove(categoria);

            _dbContextAccessCorp.SaveChanges();
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _dbContextAccessCorp.Categorias.ToList();
        }

        public Categoria GetById(int id)
        {
            return _dbContextAccessCorp.Categorias.Find(id);
        }
    }
}
