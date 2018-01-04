using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMapping()
        {
            ToTable("CATEGORIA", "FORMULARIO");

            HasKey(c => c.CategoriaId);

            Property(c => c.CategoriaId).HasColumnName("CATEGORIA_ID");
            Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(40).IsRequired();
            Property(c => c.Slug).HasColumnName("SLUG").HasMaxLength(650).IsRequired();
            Property(c => c.Descricao).HasColumnName("DESCRICAO").HasMaxLength(300);            
        }
    }
}
