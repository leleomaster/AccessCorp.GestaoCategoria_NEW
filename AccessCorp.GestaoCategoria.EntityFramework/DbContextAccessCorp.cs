using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.EntityFramework.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class DbContextAccessCorp : DbContext
    {
        public DbContextAccessCorp()
            : base("EFConnectionStringAccessCorp")
        {

        }

        public virtual DbSet<Campo> Campos { get; set; }
        public virtual DbSet<TextoCampo> TextoCampos { get; set; }
        public virtual DbSet<SubCategoria> SubCategorias { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<TipoCampo> TipoCampos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampoMapping());
            modelBuilder.Configurations.Add(new TextoCampoMapping());
            modelBuilder.Configurations.Add(new CategoriaMapping());
            modelBuilder.Configurations.Add(new SubCategoriaMapping());
            modelBuilder.Configurations.Add(new TipoCampoMapping());
            
            base.OnModelCreating(modelBuilder); 
        }
    }
}
