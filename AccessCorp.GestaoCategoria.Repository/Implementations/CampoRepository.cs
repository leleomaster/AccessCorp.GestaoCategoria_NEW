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
    public class CampoRepository : ICampoRepository
    {
        private readonly DbContextAccessCorp _dbContextAccessCorp;

        public CampoRepository()
        {
            _dbContextAccessCorp = FactoryDbContextAccessCorp.CreateDbContextAccessCorp();
        }

        public void Cadastrar(Campo campo)
        {
            var tipoCampo = _dbContextAccessCorp.TipoCampos.Find(campo.TipoCampo.TipoCampoId);
            var subCategoria = _dbContextAccessCorp.SubCategorias.Find(campo.SubCategoria.SubCategoriaId);

            campo.TipoCampo = tipoCampo;
            campo.SubCategoria = subCategoria;

            _dbContextAccessCorp.Campos.Add(campo);

            _dbContextAccessCorp.SaveChanges();
        }
    }
}
