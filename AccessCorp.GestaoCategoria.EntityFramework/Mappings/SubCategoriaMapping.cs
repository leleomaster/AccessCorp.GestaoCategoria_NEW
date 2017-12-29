using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class SubCategoriaMapping : EntityTypeConfiguration<SubCategoria>
    {
        public SubCategoriaMapping()
        {
            ToTable("SUBCATEGORIA","FORMULARIO");
            
            HasKey(s => s.SubCategoriaId);

            Property(s => s.SubCategoriaId).HasColumnName("SUB_CATEGORIA_ID");
            Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(40).IsRequired();
            Property(c => c.Slug).HasColumnName("SLUG").HasMaxLength(650).IsRequired();
            Property(c => c.Descricao).HasColumnName("DESCRICAO").HasMaxLength(300);

            HasRequired(c => c.Categoria)
                 .WithMany(c => c.SubCategorias)
                  .Map(m => m.MapKey("CATEGORIA_ID"));            
        }
    }
}
