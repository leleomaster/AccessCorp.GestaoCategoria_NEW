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
            ToTable("SUBCATEGORIA");

            HasKey(s => s.Id);

            Property(s => s.Id).HasColumnName("ID");
            Property(s => s.Nome).HasColumnName("NOME");
            Property(s => s.Slug).HasColumnName("SLUG");
            Property(s => s.Descricao).HasColumnName("DESCRICAO");

            //Mapeando o relacionamento
            HasRequired(s => s.Categoria)
            .WithMany(s => s.SubCategorias)
            .HasForeignKey(s => s.Id);         
        }
    }
}
