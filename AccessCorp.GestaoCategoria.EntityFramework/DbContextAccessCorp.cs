using AccessCorp.GestaoCategoria.Domain.Models;
using AccessCorp.GestaoCategoria.EntityFramework.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
            //Aqui vamos remover a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /*Desabilitamos o delete em cascata em relacionamentos 1:N evitando
             ter registros filhos     sem registros pai*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CampoMapping());
            modelBuilder.Configurations.Add(new TextoCampoMapping());
            modelBuilder.Configurations.Add(new CategoriaMapping());
            modelBuilder.Configurations.Add(new SubCategoriaMapping());
            modelBuilder.Configurations.Add(new TipoCampoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
