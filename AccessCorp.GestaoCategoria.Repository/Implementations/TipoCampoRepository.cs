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
    public class TipoCampoRepository : ITipoCampoRepository
    {
        private readonly DbContextAccessCorp _dbContextAccessCorp;

        public TipoCampoRepository()
        {
            _dbContextAccessCorp = FactoryDbContextAccessCorp.CreateDbContextAccessCorp();
        }

        public IEnumerable<TipoCampo> GetAll()
        {
            return _dbContextAccessCorp.TipoCampos.ToList();
        }
    }
}
