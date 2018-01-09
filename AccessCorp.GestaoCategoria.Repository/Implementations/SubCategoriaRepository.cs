using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Factories;
using AccessCorp.GestaoCategoria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessCorp.GestaoCategoria.Domain.Models;

namespace AccessCorp.GestaoCategoria.Repository.Implementations
{
    public class SubCategoriaRepository: ISubCategoriaRepository
    {
        private readonly DbContextAccessCorp _dbContextAccessCorp;

        public SubCategoriaRepository()
        {
            _dbContextAccessCorp = FactoryDbContextAccessCorp.CreateDbContextAccessCorp();
        }

        public IEnumerable<SubCategoria> GetAll()
        {
            return _dbContextAccessCorp.SubCategorias.ToList();
        }

        public void Cadastrar(SubCategoria subCategoria)
        {
            _dbContextAccessCorp.SubCategorias.Add(subCategoria);

            _dbContextAccessCorp.SaveChanges();
        }
    }
}
