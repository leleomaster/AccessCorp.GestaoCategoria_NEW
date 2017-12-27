using AccessCorp.GestaoCategoria.EntityFramework;
using AccessCorp.GestaoCategoria.EntityFramework.Factories;
using AccessCorp.GestaoCategoria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Repository.Implementations
{
    public class TextoCampoRepository : ITextoCampoRepository
    {
        private readonly DbContextAccessCorp _dbContextAccessCorp;

        public TextoCampoRepository()
        {
            _dbContextAccessCorp = FactoryDbContextAccessCorp.CreateDbContextAccessCorp();
        }
    }
}
